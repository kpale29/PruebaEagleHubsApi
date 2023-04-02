using ConsumoResponsableApi.Application.Repositories.Interface.Base;
using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Domain.Models.Consumption.RepositoryFilters;
using ConsumoResponsableApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ConsumoResponsableApi.Application.Repositories.Implementation
{
    public class ConsumptionRepository : IRepositoryGetById<GetConsumptionByIdRequest, Consumption>,
                                         IRepositoryPost<Consumption, Consumption>,
                                         IRepositoryPut<Consumption> 
    {
        private readonly ApplicationDbContext _context;
        public ConsumptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Consumption> GetByIdAsync(GetConsumptionByIdRequest filterData) =>  await _context.Consumptions.FirstAsync(c => c.Id == filterData.Id);
        

        public async Task<Consumption> PostAsync(Consumption data)
        {
            _context.Consumptions.Add(data);
            await _context.SaveChangesAsync();
            return data;    
;        }

        public async Task<Consumption> PutAsync(Consumption data)
        {
            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return data;
        }
    }
}
