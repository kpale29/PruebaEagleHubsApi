namespace ConsumoResponsableApi.Application.Repositories.Interface.Base
{
    public interface IRepositoryDelete<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<TResponse> DeleteAsync(TRequest data);
    }

    public interface IRepositoryDelete<TModel> where TModel : class
    {
        Task<TModel> DeleteAsync(TModel data);
    }
}