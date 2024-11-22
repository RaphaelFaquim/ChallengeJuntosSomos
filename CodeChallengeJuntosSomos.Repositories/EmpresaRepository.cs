
using CodeChallengeJuntosSomos.Borders.Dtos;
using CodeChallengeJuntosSomos.Borders.Repositories;

namespace CodeChallengeJuntosSomos.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public Task<Insumo> Get(Insumo request)
        {
            return Task.FromResult(request);
        }

        public Task<Insumo> Send(Insumo request)
        {
            return Task.FromResult(request);
        }
    }
}
