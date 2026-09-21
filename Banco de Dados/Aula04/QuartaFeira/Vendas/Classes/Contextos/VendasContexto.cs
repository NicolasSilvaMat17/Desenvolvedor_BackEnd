using Microsoft.EntityFrameworkCore;
using Vendas.Classes.Entidades;

namespace Vendas.Classes.Contextos
{
    internal class VendasContexto : DbContext
    {
        // Propriedades
        public DbSet<Vendas1> vendas { get; set; }

        // Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=CamisasSENAI;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Vendas1>(entidade =>
            {
                entidade.ToTable("VendasMarket");
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.DataCompra);
                entidade.Property(e => e.Tipo);
                entidade.Property(e => e.Marca);
                entidade.Property(e => e.Faturamento);
                entidade.Property(e => e.Lucro);
            });
        }

    }
}

