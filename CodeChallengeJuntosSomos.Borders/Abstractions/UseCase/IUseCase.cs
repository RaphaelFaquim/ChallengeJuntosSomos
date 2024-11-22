
namespace CodeChallengeJuntosSomos.Borders.Abstractions.UseCase
{
    public interface IUseCase<in TRequest, TResponse>
    {
        public Task<UseCaseResponse<TResponse>> Execute(TRequest request);
    }
}
