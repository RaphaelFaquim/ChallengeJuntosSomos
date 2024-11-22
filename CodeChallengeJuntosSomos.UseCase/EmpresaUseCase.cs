
using CodeChallengeJuntosSomos.Borders.Abstractions.UseCase;
using CodeChallengeJuntosSomos.Borders.Dtos;
using CodeChallengeJuntosSomos.Borders.Extensions;
using CodeChallengeJuntosSomos.Borders.Repositories;
using CodeChallengeJuntosSomos.Borders.UseCases;
using CodeChallengeJuntosSomos.Shared.Helpers;
using Microsoft.AspNetCore.Http;

namespace CodeChallengeJuntosSomos.UseCase
{
    public class EmpresaUseCase(IEmpresaRepository iEmpresarepository) : IEmpresaUseCase
    {

        private readonly IEmpresaRepository iEmpresarepository = iEmpresarepository;

        public async Task<UseCaseResponse<Insumo>> EmpresaArquivoCSV(IFormFile request)
        {
            var response = new UseCaseResponse<Insumo>();
            try
            {
                var excel = new ExcelHelper<InsumoCsv>(request);
                var insumo = excel.GetValues();
                response.Ok(await iEmpresarepository.Send(insumo.ConvertInsumoCsvToInsumo()));

            }
            catch (Exception)
            {
                response.BadRequest();
            }
            return response;

        }

        public async Task<UseCaseResponse<Insumo>> EmpresaArquivoJSON(Insumo request)
        {
                return await Execute(request);
        }

        public async Task<UseCaseResponse<Insumo>> Execute(Insumo request)
        {
            var response = new UseCaseResponse<Insumo>();
            try
            {
                 response.Ok(await iEmpresarepository.Send(request));

            } catch (Exception)
            {
                response.BadRequest();
            }
            return response;
        }
    }
}
