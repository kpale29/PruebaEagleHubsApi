using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsumoResponsableApi.Domain.Entities.Base
{
    public abstract class CatBaseEntity : BaseEntity
    {
        [Comment("Catalogue item name")]
        [Required, Column(name: "name"), MaxLength(200)]
        public string Name { get; set; } = null!;
        [Comment("Catalogue item description")]
        [Required, Column(name: "description"), MaxLength(500)]
        public string Description { get; set; } = null!;
    }
}