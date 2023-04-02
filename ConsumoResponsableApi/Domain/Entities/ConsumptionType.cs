using ConsumoResponsableApi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsumoResponsableApi.Domain.Entities;
public class ConsumptionType : CatBaseEntity
{
    [Required, Column(name: "petroleum_derivative")]
    [Comment("Petroleum derivative item")]
    public bool PetroleumDerivative { get; set; } = false;
    [Required, Column(name: "emission_id")]
    [Comment("Emission Foreign key")]
    public int EmissionId { get; set; }
    [Required, Column(name: "unit_measure_id")]
    [Comment("Unit Measure Foreign key")]
    public int UnitMeasureId { get; set; }
    public Emission Emission { get; set; } = null!;
    public UnitMeasure UnitMeasure { get; set; } = null!;

}

