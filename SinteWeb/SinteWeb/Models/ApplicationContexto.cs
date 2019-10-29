using Microsoft.EntityFrameworkCore;
using SinteWeb.DadosContexto;

namespace SinteWeb.Models
{
    public class ApplicationContexto : DbContext
    {
        //public DbSet<Cliente> Clientes { get; set; }
        //public Dbset<Endereco> Enderecos { get; set; }
        //public Dbset<Equipamento> Equipamentos { get; set; }
        //public Dbset<Status> Statuses { get; set; }
        //public Dbset<OrdemDeServico> Ordemdeservicos { get; set; }

        public ApplicationContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Cliente>().HasKey(c => c.Id);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Endereco).WithOne(c => c.Cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.OrdemDeServicos).WithOne(c => c.Cliente);

            modelBuilder
                .Entity<Endereco>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.Cliente).WithOne(c => c.Endereco);

            //modelBuilder
            //    .Entity<Endereco>()
            //    .ToTable("enderecos");

            //modelBuilder
            //    .Entity<Endereco>()
            //    .Property<int>("clienteid");

            //modelBuilder
            //    .Entity<Endereco>()
            //    .HasKey("clienteid");

            modelBuilder.ApplyConfiguration(new EquipamentoConfigure());
            modelBuilder.ApplyConfiguration(new StatusConfigure());
            modelBuilder.ApplyConfiguration(new OrdemDeServicoConfigure());

        }
    }
}
