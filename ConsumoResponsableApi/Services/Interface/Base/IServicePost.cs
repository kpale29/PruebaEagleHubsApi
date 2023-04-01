
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Services.Interface.Base
{
    public interface IServicePost<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<ResponseSuccess<TResponse>> PostAsync(TRequest data);
    }

    public interface IServicePost<TModel> where TModel : class
    {
        Task<ResponseSuccess<TModel>> PostAsync(TModel data);
    }

    public interface IServiceExternalPost<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        public Task<TResponse> PostAsync(TRequest data);
    }
} 