using ConsumoResponsableApi.Application.Services.Interface.Custom;
using ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports;
using ConsumoResponsableApi.Utils.Responses;

namespace ConsumoResponsableApi.Application.Services.Implementation
{
    public class ConsumptionReportsService : IConsumptionsReport

    {
        
        public ConsumptionReportsService()
        {
            
        }

        public async Task<ResponseSuccess<GetAnualConsumptionsResponse>> GetAnualConsumptionsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetComparisonPetroleumDerivativeConsumptionsResponse>> GetPetroleumDerivativeAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetMontlyEnergyConsumptionsFactoryResponse>> GetMontlyEnergyAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetMontlyEnergyFuelComparisonResponse>> GetMontlyComparisonAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetMontlyFuelConsumptionsResponse>> GetMontlyFuelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetMontlyImpactResponse>> GetMontlyImpactAsync()
        {
            throw new NotImplementedException();
        }
    }
}
