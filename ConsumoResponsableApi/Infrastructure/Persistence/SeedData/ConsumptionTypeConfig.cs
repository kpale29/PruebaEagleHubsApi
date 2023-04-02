using ConsumoResponsableApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumoResponsableApi.Infrastructure.Persistence.SeedData
{
    public class ConsumptionTypeConfig : IEntityTypeConfiguration<ConsumptionType>
    {
        public void Configure(EntityTypeBuilder<ConsumptionType> builder)
        {
            builder.HasData(new List<ConsumptionType>()
            {
                new ConsumptionType()
                {
                    Id = 1,
                    Name = "combustible para los vehículos",
                    Description = "Consumo combustible para los vehículos",
                    UnitMeasureId = 2,
                    EmissionId= 1,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 2,
                    Name = "gases refrigerantes",
                    Description = "Perdida de gases refrigerantes",
                    UnitMeasureId = 2,
                    EmissionId= 1,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 3,
                    Name = "energía eléctrica", 
                    Description = "Consumo de energía eléctrica ",
                    UnitMeasureId = 1,
                    EmissionId= 1,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 4,
                    Name = "combustible para transportes de terceros",
                    Description = "Uso mensual de combustible para vehículos terceros",
                    UnitMeasureId = 2,
                    EmissionId= 2,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 5,
                    Name = "viajes", 
                    Description = "Viajes de miembros del equipo",
                    UnitMeasureId = 1,
                    EmissionId= 3,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 6,
                    Name = "aceite para mantenimiento", 
                    Description = "Consumo de aceite para mantenimiento",
                    UnitMeasureId = 1,
                    EmissionId= 1,
                    PetroleumDerivative = true
                },
                new ConsumptionType()
                {
                    Id = 7,
                    Name = "otros", 
                    Description = "Otros consumos (Papel, lapices, agua,etc)",
                    UnitMeasureId = 3,
                    EmissionId= 1,
                    PetroleumDerivative = false
                },
            });
        }
    }
}
