using CodeChallengeJuntosSomos.Shared;
using CodeChallengeJuntosSomos.Borders.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using CodeChallengeJuntosSomos.Borders.UseCases;
using CodeChallengeJuntosSomos.Borders.Repositories;

namespace CodeChallengeJuntosSomos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {
        private readonly ILogger<EmpresaController> _logger;
        private readonly IEmpresaRepository iEmpresarepository;


        public EmpresaController(ILogger<EmpresaController> logger, IEmpresaRepository iEmpresarepository)
        {
            _logger = logger;
            this.iEmpresarepository = iEmpresarepository;
        }

        [HttpPost("EnviarArquivoCsv")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Insumo))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(ErrorMessage))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorMessage[]))]
        public async Task<IActionResult> EnviarArquivoCsv([FromServices] IEmpresaUseCase iEmpresaUseCase, IFormFile iFormFile)
        {
            return Ok(await iEmpresaUseCase.EmpresaArquivoCSV(iFormFile));
        }
        [HttpPut("EnviarArquivoJson")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Insumo))]
        [ProducesResponseType((int)HttpStatusCode.NotFound, Type = typeof(ErrorMessage))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorMessage[]))]
        public async Task<IActionResult> EnviarArquivoJson([FromServices] IEmpresaUseCase iEmpresaUseCase, [FromBody] Insumo insumo)
        {
            return Ok(await iEmpresaUseCase.EmpresaArquivoJSON(insumo));
        }
    }
}
