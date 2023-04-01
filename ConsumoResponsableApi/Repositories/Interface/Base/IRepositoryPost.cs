
namespace ConsumoResponsableApi.Repositories.Interface.Base 
{
    public interface IRepositoryPost<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<TResponse> PostAsync(TRequest data);
    }

    public interface IRepositoryPost<TModel> where TModel : class
    { 
        Task<TModel> PostAsync(TModel data);
    }
}