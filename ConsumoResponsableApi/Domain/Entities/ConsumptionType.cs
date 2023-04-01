using ConsumoResponsableApi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsumoResponsableApi.Domain.Entities
{
    public class ConsumptionType : CatBaseEntity
    {
        [Required, Column(name: "petroleum_derivative")]
        [Comment("Petroleum derivative item")]
        public bool PetroleumDerivative { get; set; } = false;
        [Required, Column(name: "emission_id")]
        [Comment("Emission Foreign key")]
        public int EmissionId { get; set; }
        public Emission Emission { get; set; } = null!;
    }
}
