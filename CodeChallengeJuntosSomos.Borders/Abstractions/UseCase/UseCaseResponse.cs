using CodeChallengeJuntosSomos.Shared;


namespace CodeChallengeJuntosSomos.Borders.Abstractions.UseCase
{
    public class UseCaseResponse<TResponse>
    {
        public IEnumerable<ErrorMessage>? Errors { get; private set; }
        public TResponse? Content { get; private set; }
        public UseCaseResponseStatus Status { get; private set; }

        public UseCaseResponse<TResponse> Ok(TResponse content)
        {
            Content = content;
            return SetStatus(UseCaseResponseStatus.Ok);
        }
        public UseCaseResponse<TResponse> BadRequest()
        {
            return SetStatus(UseCaseResponseStatus.BadRequest);
        }
        private UseCaseResponse<TResponse> SetStatus(UseCaseResponseStatus status,
            IEnumerable<ErrorMessage>? errors = null)
        {
            Status = status;
            Errors = errors;

            return this;
        }
    }
}
