using Azure.Core;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Application.Services.Interface.Base
{
    public interface IServiceGet<TResponse> where TResponse : class
    {
        public Task<ResponseSuccess<TResponse>> GetAsync();
    }
    public interface IServiceGetById<TRequest, TResponse> where TRequest : class
    {
        public Task<ResponseSuccess<TResponse>> GetByIdAsync(TRequest filterData);
    }

    public interface IServiceGetAll<TResponse> where TResponse : class
    {
        public Task<ResponseSuccess<List<TResponse>>> GetAllAsync();
    }

    public interface IServiceGetAllDetail<TResponse> where TResponse : class
    {
        public Task<ResponseSuccess<List<TResponse>>> GetAllDetailAsync();
    }

    public interface IServiceGetAllById<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        public Task<ResponseSuccess<List<TResponse>>> GetAllByIdAsync(TRequest filterData);
    }

    public interface IServiceExternalGetById<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        public Task<TResponse> GetByIdAsync(TRequest filterData);
    }

}