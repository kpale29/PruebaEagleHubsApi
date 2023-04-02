using ConsumoResponsableApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumoResponsableApi.Infrastructure.Persistence.SeedData
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new List<Company>()
            {
                new Company()
                {
                    Id = 1,
                    Description = "Fabrica Industrial S.A.",
                    Name = "Fabrica Industrial S.A.",
                }
            });
        }
    }
}
