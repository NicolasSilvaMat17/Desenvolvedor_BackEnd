using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class LoginContexto : DbContext
    {
        // Prporiedade
        public DbSet<Produtos> Produtos { get; set; }

        // Metodo
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeoDeCostrucao)
        {
                modeoDeCostrucao.Entity<Produtos>(entidade =>
                { 
                    entidade.HasKey(e => e.CodigoDoProduto);
                    entidade.Property(e => e.NomeDoProduto);
                    entidade.Property(e => e.QuantidadeDeProdiuto);
                    entidade.Property(e => e.ValorDoProuto);
                });
        }
    }
}
