using ConsumoResponsableApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumoResponsableApi.Infrastructure.Persistence.SeedData
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(new List<Location>()
            {
                new Location()
                {
                    Id = 1,
                    Description = "Area administrativa",
                    Name = "Administracion",
                    CompanyId = 1,
                },
                new Location()
                {
                    Id = 2,
                    Description = "Area de distribucion",
                    Name = "Distribucion",
                    CompanyId = 1,
                },
                new Location()
                {
                    Id = 3,
                    Description = "Proveedores de transportes",
                    Name = "Transportes Terceros",
                    CompanyId = 1,
                },
                 new Location()
                {
                    Id = 4,
                    Description = "Area gerencial",
                    Name = "Gerencia",
                    CompanyId = 1,
                },
                new Location()
                {
                    Id = 5,
                    Description = "Area de planta de envasado",
                    Name = "Planta de envasado",
                    CompanyId = 1,
                },
                new Location()
                {
                    Id = 6,
                    Description = "Area de operaciones",
                    Name = "Operaciones",
                    CompanyId = 1,
                },
            });
        }
    }
}
