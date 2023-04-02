using ConsumoResponsableApi.Application.Repositories.Interface.Base;
using ConsumoResponsableApi.Application.Services.Interface.Base;
using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Domain.Models.Consumption.RepositoryFilters;
using ConsumoResponsableApi.Domain.Models.Consumption.Request;
using ConsumoResponsableApi.Domain.Models.Consumption.Response;
using ConsumoResponsableApi.Utils.Enums;
using ConsumoResponsableApi.Utils.Exceptions;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Application.Services.Implementation
{
    public class ConsumptionService : IServicePost<PostFuelConsumptionRequest, PostDefaultConsumptionResponse>,
                                      IServicePost<PostEnergyConsumptionRequest, PostDefaultConsumptionResponse>,
                                      IServicePost<PostOtherConsumptionRequest, PostDefaultConsumptionResponse>,
                                      IServicePost<PostTravelConsumptionRequest, PostDefaultConsumptionResponse>,
                                      IServicePut<PutConsumptionRequest, PostDefaultConsumptionResponse>

    {
        private readonly IRepositoryPost<Consumption, Consumption> _repositoryPost;
        private readonly IRepositoryGetById<GetConsumptionByIdRequest, Consumption> _consumptionGetByIdRepository;
        private readonly IRepositoryPut<Consumption> _consumptionPutRepository;
        private readonly IRepositoryGetAll<ConsumptionType> _consumptionTypeGetRepository;
        private readonly IRepositoryGetAll<Location> _locationTypeGetRepository;

        public ConsumptionService(
            IRepositoryPost<Consumption, Consumption> repositoryPost,
            IRepositoryGetAll<ConsumptionType> consumptionTypeGetRepository,
            IRepositoryGetAll<Location> locationTypeGetRepository,
            IRepositoryGetById<GetConsumptionByIdRequest, Consumption> consumptionGetByIdRepository,
            IRepositoryPut<Consumption> consumptionPutRepository
            )
        {
            _repositoryPost = repositoryPost;
            _consumptionTypeGetRepository = consumptionTypeGetRepository;
            _locationTypeGetRepository = locationTypeGetRepository;
            _consumptionGetByIdRepository = consumptionGetByIdRepository;
            _consumptionPutRepository = consumptionPutRepository;
        }

        public async Task<ResponseSuccess<PostDefaultConsumptionResponse>> PostAsync(PostFuelConsumptionRequest data)
        {
            List<Location> locations = await _locationTypeGetRepository.GetAllAsync();
            Location? selectedLocation = locations.FirstOrDefault(c => c.Id == data.LocationId);
            if (selectedLocation == null) throw new HttpException(HttpEnums.BadRequest, "El area seleccionado no es valido");

            Consumption newConsumption = new()
            {
                ConsumptionTypeId = 1,
                Quantity = data.Quantity,
                LocationId = data.LocationId,
                ExecutedAt = data.ExecutedAt,
            };

            await _repositoryPost.PostAsync(newConsumption);

            return new ResponseSuccess<PostDefaultConsumptionResponse>(HttpEnums.Ok, new()
            {
                Message = "Consumo registrado correctamente"
            });
        }

        public async Task<ResponseSuccess<PostDefaultConsumptionResponse>> PostAsync(PostEnergyConsumptionRequest data)
        {
            List<Location> locations = await _locationTypeGetRepository.GetAllAsync();
            Location? selectedLocation = locations.FirstOrDefault(c => c.Id == data.LocationId);
            if (selectedLocation == null) throw new HttpException(HttpEnums.BadRequest, "El area seleccionado no es valido");

            Consumption newConsumption = new()
            {
                ConsumptionTypeId = 3,
                Quantity = data.Quantity,
                LocationId = data.LocationId,
                ExecutedAt = data.ExecutedAt,
            };

            await _repositoryPost.PostAsync(newConsumption);

            return new ResponseSuccess<PostDefaultConsumptionResponse>(HttpEnums.Ok, new()
            {
                Message = "Consumo registrado correctamente"
            });
        }

        public async Task<ResponseSuccess<PostDefaultConsumptionResponse>> PostAsync(PostOtherConsumptionRequest data)
        {
            List<Location> locations = await _locationTypeGetRepository.GetAllAsync();
            Location? selectedLocation = locations.FirstOrDefault(c => c.Id == data.LocationId);
            if (selectedLocation == null) throw new HttpException(HttpEnums.BadRequest, "El area seleccionado no es valido");

            List<ConsumptionType> consumptionTypes = await _consumptionTypeGetRepository.GetAllAsync();
            ConsumptionType? selectedConsumptionType = consumptionTypes.FirstOrDefault(c => c.Id == data.ConsumptionTypeId);
            if (selectedConsumptionType == null || !selectedConsumptionType.PetroleumDerivative)
                throw new HttpException(HttpEnums.BadRequest, "El tipo de consumo seleccionado no es valido");

            Consumption newConsumption = new()
            {
                ConsumptionTypeId = data.ConsumptionTypeId,
                Quantity = data.Quantity,
                LocationId = data.LocationId,
                ExecutedAt = data.ExecutedAt,
            };

            await _repositoryPost.PostAsync(newConsumption);

            return new ResponseSuccess<PostDefaultConsumptionResponse>(HttpEnums.Ok, new()
            {
                Message = "Consumo registrado correctamente"
            });
        }

        public async Task<ResponseSuccess<PostDefaultConsumptionResponse>> PostAsync(PostTravelConsumptionRequest data)
        {
            List<Location> locations = await _locationTypeGetRepository.GetAllAsync();
            Location? selectedLocation = locations.FirstOrDefault(c => c.Id == data.LocationId);
            if (selectedLocation == null) throw new HttpException(HttpEnums.BadRequest, "El area seleccionado no es valido");

            Consumption newConsumption = new()
            {
                ConsumptionTypeId = 5,
                Quantity = data.Quantity,
                LocationId = data.LocationId,
                ExecutedAt = data.ExecutedAt,
            };

            await _repositoryPost.PostAsync(newConsumption);

            return new ResponseSuccess<PostDefaultConsumptionResponse>(HttpEnums.Ok, new()
            {
                Message = "Consumo registrado correctamente"
            });
        }

        public async Task<ResponseSuccess<PostDefaultConsumptionResponse>> PutAsync(PutConsumptionRequest data)
        {
            Consumption consumptionToUpdate = await _consumptionGetByIdRepository.GetByIdAsync(new()
            {
                Id = 1
            });

            await _consumptionPutRepository.PutAsync(consumptionToUpdate);

            return new ResponseSuccess<PostDefaultConsumptionResponse>(HttpEnums.Ok, new()
            {
                Message = "Consumo registrado correctamente"
            });
        }
    }
}
