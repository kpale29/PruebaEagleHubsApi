using ConsumoResponsableApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumoResponsableApi.Infrastructure.Persistence.SeedData
{
    public class EmissionConfig : IEntityTypeConfiguration<Emission>
    {
        public void Configure(EntityTypeBuilder<Emission> builder)
        {
            builder.HasData(new List<Emission>()
            {
                new Emission()
                {
                    Id = 1,
                    Name = "directas",
                    Description = "Asociadas a las actividades de la organización y que están controladas por dicha organización.",
                },
                new Emission()
                {
                    Id = 2,
                    Name = "indirectas",
                    Description= "Asociadas al consumo energético adquirido y consumido por la organización.",
                },
                new Emission()
                {
                    Id = 3,
                    Name = "otras",
                    Description = "Asociadas a otras actividades no controladas por la organización.",
                },
            });
        }
    }
}
