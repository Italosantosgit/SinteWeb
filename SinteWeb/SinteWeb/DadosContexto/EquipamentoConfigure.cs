using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinteWeb.Models;

namespace SinteWeb.DadosContexto
{
    public class EquipamentoConfigure : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.HasKey(eqc => eqc.Id);

            //CONVERSAO DO ENUM PARA STRING
            builder.Property(eqc => eqc.TipoEquipamento).HasConversion<string>();

            builder.HasMany(eqc => eqc.OrdemDeServicos).WithOne(eqc => eqc.Equipamento);
        }
    }
}
