using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinteWeb.Models;
using System;

namespace SinteWeb.DadosContexto
{
    public class OrdemDeServicoConfigure : IEntityTypeConfiguration<OrdemDeServico>
    {
        public void Configure(EntityTypeBuilder<OrdemDeServico> builder)
        {
            builder.HasKey(odsc => odsc.Id);

            //CONVERTENDO ENUM PARA STRING
            builder.Property(odsc => odsc.FormaPagamento).HasConversion<string>();

            //CONVERTENDO ENUM PARA STRING
            builder.Property(odsc => odsc.TipoOrdemServico).HasConversion<string>();

            builder.HasOne(odsc => odsc.Status).WithMany(odsc => odsc.OrdemDeServicos);

            builder.HasOne(odsc => odsc.Equipamento).WithMany(odsc => odsc.OrdemDeServicos);

            builder.Property<DateTime>("last_update")
                .IsRequired()
                .HasDefaultValueSql("getdate()");
        }
    }
}
