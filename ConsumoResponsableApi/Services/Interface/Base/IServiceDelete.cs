
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Services.Interface.Base
{ 
    public interface IServiceDelete<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        public Task<ResponseSuccess<TResponse>> DeleteAsync(TRequest data);
    }

    public interface IServiceDelete<TModel> where TModel : class
    {
        Task<ResponseSuccess<TModel>> DeleteAsync(TModel data);
    }
} 