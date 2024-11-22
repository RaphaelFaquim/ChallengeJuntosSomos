using CodeChallengeJuntosSomos.Borders.Dtos;

namespace CodeChallengeJuntosSomos.Borders.Repositories
{
    public interface IEmpresaRepository
    {
        Task<Insumo> Send(Insumo request);
        Task<Insumo> Get(Insumo request);
    }
}
