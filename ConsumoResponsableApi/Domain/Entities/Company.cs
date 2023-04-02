using ConsumoResponsableApi.Domain.Entities.Base;

namespace ConsumoResponsableApi.Domain.Entities;
public class Company : CatBaseEntity
{
    public virtual IEnumerable<Location> Locations { get; set; } = null!;
}

