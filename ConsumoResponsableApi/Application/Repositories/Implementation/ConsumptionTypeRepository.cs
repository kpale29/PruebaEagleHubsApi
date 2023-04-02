using ConsumoResponsableApi.Application.Repositories.Interface.Base;
using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ConsumoResponsableApi.Application.Repositories.Implementation
{
    public class ConsumptionTypeRepository : IRepositoryGetAll<ConsumptionType>
    {
        private readonly ApplicationDbContext _context;
        public ConsumptionTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ConsumptionType>> GetAllAsync() => await _context.ConsumptionTypes.ToListAsync();
    }
}
