using ConsumoResponsableApi.Application.Repositories.Interface.Base;
using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ConsumoResponsableApi.Application.Repositories.Implementation
{
    public class LocationsRepository : IRepositoryGetAll<Location>
    {
        private readonly ApplicationDbContext _context;
        public LocationsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Location>> GetAllAsync() => _context.Locations.ToListAsync();
    }
}
