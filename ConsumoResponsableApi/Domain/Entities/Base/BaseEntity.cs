using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsumoResponsableApi.Domain.Entities.Base;
public abstract class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name: "id")]
    [Comment("Entity Primary Key")]
    public int Id { get; set; }
    [Required, Column(name: "created_at")]
    [Comment("Creation date")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Column(name: "updated_at")]
    [Comment("Update date")]
    public DateTime? UpdatedAt { get; set; }
    [Required, Column(name: "active")]
    [Comment("Status of register")]
    public bool Active { get; set; } = true;
    [Column(name: "deleted_at")]
    [Comment("Delete date")]
    public DateTime? DeletedAt { get; set; }
}