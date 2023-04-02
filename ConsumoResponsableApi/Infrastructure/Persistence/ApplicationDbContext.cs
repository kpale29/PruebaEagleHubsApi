using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ConsumoResponsableApi.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Consumption> Consumptions { get; set; } = null!;
        public DbSet<ConsumptionType> ConsumptionTypes { get; set; } = null!;
        public DbSet<Emission> Emissions { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<UnitMeasure> UnitMeasures { get; set; } = null!;

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<EntityEntry> entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && e.State is EntityState.Added or EntityState.Modified);


            foreach (EntityEntry entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
                        ((BaseEntity)entityEntry.Entity).Active = true;
                        break;
                    case EntityState.Modified:
                        ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.UtcNow;
                        Entry((BaseEntity)entityEntry.Entity).Property(x => x.CreatedAt).IsModified = false;
                        break;
                    default:
                        continue;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }


    }


}
