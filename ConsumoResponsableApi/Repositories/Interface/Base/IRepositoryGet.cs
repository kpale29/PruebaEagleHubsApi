
namespace ConsumoResponsableApi.Repositories.Interface.Base 
{
    public interface IRepositoryGet<TResponse> where TResponse : class
    {
        public Task<TResponse> GetAsync();
    }

    public interface IRepositoryGetById<TRequest, TResponse> where TResponse : class where TRequest : class
    {
        public Task<TResponse> GetByIdAsync(TRequest filterData);
    }
    public interface IRepositoryGetAll<TResponseGetAll> where TResponseGetAll : class
    {
        public Task<List<TResponseGetAll>> GetAllAsync();
    }

    public interface IRepositoryGetAllDetail<TResponseGetAllDetail> where TResponseGetAllDetail : class
        {
        public Task<List<TResponseGetAllDetail>> GetAllDetailAsync();
    }

    public interface IRepositoryGetAllById<TRequestGetAllById, TResponseGetAllById> where TResponseGetAllById : class where TRequestGetAllById : class
        {
        public Task<List<TResponseGetAllById>> GetAllByIdAsync(TRequestGetAllById filterData);
    }
}