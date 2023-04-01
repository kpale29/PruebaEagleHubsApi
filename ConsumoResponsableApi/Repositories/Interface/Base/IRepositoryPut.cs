
namespace ConsumoResponsableApi.Repositories.Interface.Base 
{
    public interface IRepositoryPut<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<TResponse> PutAsync(TRequest data);
    }

    public interface IRepositoryPut<TModel> where TModel : class
    {
        Task<TModel> PutAsync(TModel data);
    }
}