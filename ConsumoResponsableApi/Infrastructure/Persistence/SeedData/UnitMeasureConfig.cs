using ConsumoResponsableApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumoResponsableApi.Infrastructure.Persistence.SeedData
{
    public class UnitMeasureConfig : IEntityTypeConfiguration<UnitMeasure>
    {
        public void Configure(EntityTypeBuilder<UnitMeasure> builder)
        {
            builder.HasData(new List<UnitMeasure>()
            {
                new UnitMeasure()
                {
                    Id = 1,
                    Name = "kw",
                    Description = "Kilo Watts",
                },
                new UnitMeasure()
                {
                    Id = 2,
                    Name = "galon",
                    Description= "Galones",
                },
                new UnitMeasure()
                {
                    Id = 3,
                    Name = "unidad",
                    Description = "Unidad",
                },
            });
        }
    }
}
