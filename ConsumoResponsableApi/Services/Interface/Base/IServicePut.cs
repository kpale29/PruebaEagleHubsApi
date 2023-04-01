
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Services.Interface.Base
{ 
    public interface IServicePut<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<ResponseSuccess<TResponse>> PutAsync(TRequest data);
    }

    public interface IServicePut<TModel> where TModel : class
    {
        public Task<ResponseSuccess<TModel>> PutAsync();
    } 
}  