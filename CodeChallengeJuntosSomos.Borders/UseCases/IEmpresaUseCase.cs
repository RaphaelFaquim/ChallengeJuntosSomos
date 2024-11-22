
using CodeChallengeJuntosSomos.Borders.Abstractions.UseCase;
using CodeChallengeJuntosSomos.Borders.Dtos;

namespace CodeChallengeJuntosSomos.Borders.UseCases
{
    public interface IEmpresaUseCase : IUseCase<Insumo, Insumo>
    {
        Task<UseCaseResponse<Insumo>> EmpresaArquivoJSON(Insumo request);
        Task<UseCaseResponse<Insumo>> EmpresaArquivoCSV(string request);
    }
}
