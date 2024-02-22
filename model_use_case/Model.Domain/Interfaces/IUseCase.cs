namespace Model.Domain.Interfaces
{
    public interface IUseCase<in TRequest>
    {
        void Execute(TRequest request);
    }

    public interface IUseCase<in TRequest, out TResponse>
    {
        TResponse Execute(TRequest request);
    }

    //public interface IUseCaseAsync<in TRequest>
    //{
    //    Task Execute(TRequest request);
    //}

    //public interface IUseCaseAsync<in TRequest, out TResponse>
    //{
    //    Task<TResponse> Execute(TRequest request);
    //}
}
