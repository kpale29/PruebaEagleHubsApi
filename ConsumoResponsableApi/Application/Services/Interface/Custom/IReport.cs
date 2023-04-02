using Azure.Core;
using ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Application.Services.Interface.Custom
{
    public interface IConsumptionsReport
    {
        public Task<ResponseSuccess<List<GetAnualConsumptionsResponse>>> GetAnualConsumptionsAsync();
        public Task<ResponseSuccess<List<GetComparisonPetroleumDerivativeConsumptionsResponse>>> GetPetroleumDerivativeAsync();
        public Task<ResponseSuccess<GetMontlyEnergyConsumptionsFactoryResponse>> GetMontlyEnergyAsync();
        public Task<ResponseSuccess<GetMontlyEnergyFuelComparisonResponse>> GetMontlyComparisonAsync();
        public Task<ResponseSuccess<List<GetMontlyFuelConsumptionsResponse>>> GetMontlyFuelAsync();
        public Task<ResponseSuccess<List<GetMontlyImpactResponse>>> GetMontlyImpactAsync();
    }
}
