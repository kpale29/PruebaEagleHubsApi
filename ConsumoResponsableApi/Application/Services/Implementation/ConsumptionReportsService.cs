using Azure;
using ConsumoResponsableApi.Application.Services.Interface.Custom;
using ConsumoResponsableApi.Domain.Models.Consumption.Response;
using ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports;
using ConsumoResponsableApi.Infrastructure.Persistence;
using ConsumoResponsableApi.Utils.Enums;
using ConsumoResponsableApi.Utils.Responses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConsumoResponsableApi.Application.Services.Implementation
{
    public class ConsumptionReportsService : IConsumptionsReport

    {
        private readonly ApplicationDbContext _context;
        public ConsumptionReportsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseSuccess<List<GetAnualConsumptionsResponse>>> GetAnualConsumptionsAsync()
        {
            var result = await _context.Consumptions
                 .Include(c => c.Location)
                 .Include(c => c.ConsumptionType)
                 .Where(c => c.ConsumptionTypeId == 1 || c.ConsumptionTypeId == 4)
                 .GroupBy(c => new { AreaName = c.Location.Name, c.ExecutedAt.Year })
                 .Select(g => new { g.Key.AreaName, Total = g.Sum(c => c.Quantity), g.Key.Year })
                 .ToListAsync();

            int total = result.Sum(g => g.Total);

            List<GetAnualConsumptionsResponse> response = new();
            foreach (var item in result)
            {
                response.Add(new()
                {
                    LocationName = item.AreaName,
                    Percentage = (double)item.Total / total * 100,
                    Year = item.Year
                });
            }

            return new ResponseSuccess<List<GetAnualConsumptionsResponse>>(HttpEnums.Ok, response);
        }
        public async Task<ResponseSuccess<List<GetMontlyFuelConsumptionsResponse>>> GetMontlyFuelAsync()
        {
            var result = await _context.Consumptions
                .Where(c => c.ConsumptionTypeId == 1 || c.ConsumptionTypeId == 4)
                .GroupBy(c => new { c.ExecutedAt.Year, c.ExecutedAt.Month })
                .Select(g => new GetMontlyFuelConsumptionsResponse()
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    AverageAmount = g.Average(c => c.Quantity)
                }).ToListAsync();

            return new ResponseSuccess<List<GetMontlyFuelConsumptionsResponse>>(HttpEnums.Ok, result);
        }
        public async Task<ResponseSuccess<List<GetMontlyImpactResponse>>> GetMontlyImpactAsync()
        {
            var result = await _context.Consumptions
                .Where(c => c.ConsumptionTypeId == 1 || c.ConsumptionTypeId == 4)
                .GroupBy(c => new { c.Location.Name, c.ExecutedAt.Month , c.ExecutedAt.Year})
                .Select(g => new { LocationName =  g.Key.Name, Total = g.Sum(c => c.Quantity), g.Key.Year, g.Key.Month })
                .ToListAsync();

            int total = result.Sum(g => g.Total);

            List<GetMontlyImpactResponse> response = new();

            foreach (var item in result)
            {
                response.Add(new()
                {
                    LocationName = item.LocationName,
                    Month= item.Month,
                    Percentaje = (double)item.Total / total * 100,
                    Year = item.Year,
                });
            }

            return new ResponseSuccess<List<GetMontlyImpactResponse>>(HttpEnums.Ok, response);
        }

        public async Task<ResponseSuccess<List<GetComparisonPetroleumDerivativeConsumptionsResponse>>> GetPetroleumDerivativeAsync()
        {
            List<GetComparisonPetroleumDerivativeConsumptionsResponse> response = new();

            return new ResponseSuccess<List<GetComparisonPetroleumDerivativeConsumptionsResponse>>(HttpEnums.Ok, response);
        }

        public async Task<ResponseSuccess<GetMontlyEnergyConsumptionsFactoryResponse>> GetMontlyEnergyAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseSuccess<GetMontlyEnergyFuelComparisonResponse>> GetMontlyComparisonAsync()
        {
            throw new NotImplementedException();
        }


    }
}
