using ConsumoResponsableApi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsumoResponsableApi.Domain.Entities;
public class Location : CatBaseEntity
{
    [Required, Column(name: "company_id")]
    [Comment("Company Foreign key")]
    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}

