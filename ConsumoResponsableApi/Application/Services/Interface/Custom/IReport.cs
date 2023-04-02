using Azure.Core;
using ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Application.Services.Interface.Custom
{
    public interface IConsumptionsReport
    {
        public Task<ResponseSuccess<GetAnualConsumptionsResponse>> GetAnualConsumptionsAsync();
        Task<ResponseSuccess<GetComparisonPetroleumDerivativeConsumptionsResponse>> GetPetroleumDerivativeAsync();
        Task<ResponseSuccess<GetMontlyEnergyConsumptionsFactoryResponse>> GetMontlyEnergyAsync();
        Task<ResponseSuccess<GetMontlyEnergyFuelComparisonResponse>> GetMontlyComparisonAsync();
        Task<ResponseSuccess<GetMontlyFuelConsumptionsResponse>> GetMontlyFuelAsync();
        Task<ResponseSuccess<GetMontlyImpactResponse>> GetMontlyImpactAsync();
    }
}
