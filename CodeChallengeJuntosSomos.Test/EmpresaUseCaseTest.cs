using CodeChallengeJuntosSomos.Borders.UseCases;
using CodeChallengeJuntosSomos.UseCase;
using CodeChallengeJuntosSomos.Borders.Repositories;
using Moq;
using CodeChallengeJuntosSomos.Borders.Dtos;S

namespace CodeChallengeJuntosSomos.Test
{
    public class EmpresaUseCaseTest
    {
        private readonly IEmpresaUseCase iEmpresaUseCase;
        private readonly Mock<IEmpresaRepository> iEmpresaRepository;

        public EmpresaUseCaseTest()
        {
            iEmpresaRepository = new Mock<IEmpresaRepository>();
            iEmpresaUseCase = new EmpresaUseCase(iEmpresaRepository.Object);
        }

        [Test]
        public async Task ValidacaoTest_ok()
        {
            var insumo = new Mock<Insumo>();

            var response = await iEmpresaUseCase.Execute(insumo.Object);
            Assert.Pass();
        }
        [Test]
        public async Task ValidacaoTest_Notok()
        {
            var insumo = new Mock<Insumo>();
            iEmpresaRepository.Setup(x => x.Send(It.IsAny<Insumo>())).ThrowsAsync(new Exception()).Verifiable();


            var response = await iEmpresaUseCase.Execute(insumo.Object);
            iEmpresaRepository.VerifyAll();
        }
    }
}
