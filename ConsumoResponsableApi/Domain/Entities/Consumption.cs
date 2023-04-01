using ConsumoResponsableApi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsumoResponsableApi.Domain.Entities
{
    public class Consumption : CatBaseEntity 
    {
        [Required, Column(name: "quantity")]
        [Comment("Consumption quantity")]
        public int Quantity { get; set; }
        [Required, Column(name: "consumption_type_id")]
        [Comment("Consumption Type Foreign key")]
        public int ConsumptionTypeId { get; set; }
        [Required, Column(name: "unit_measure_id")]
        [Comment("Unit Measure Foreign key")]
        public int UnitMeasureId { get; set; }
        [Required, Column(name: "location_id")]
        [Comment("Location Foreign key")]
        public int LocationId { get; set; }
        public ConsumptionType ConsumptionType { get; set; } = null!;
        public UnitMeasure UnitMeasure { get; set; } = null!;
        public Location Location { get; set; } = null!;


    }
}
