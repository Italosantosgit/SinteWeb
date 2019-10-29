using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinteWeb.Models;

namespace SinteWeb.DadosContexto
{
    public class StatusConfigure : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(sc => sc.Id);

            //CONVERSAO DO ENUM PARA STRING
            builder.Property(sc => sc.TipoStatus).HasConversion<string>();

            builder.HasMany(sc => sc.OrdemDeServicos).WithOne(sc => sc.Status);
        }
    }
}
