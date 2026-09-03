using CasasBahia.Classe.Entidade;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classe.Contexto
{
    internal class ProdutoContexto : DbContext
    {
        // Propriedade para acessar a tabela de produtos no banco de dados
        public DbSet<Produto> Produtos { get; set; }

        // Métodos para configurar o contexto do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder opcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=true;TrustServerCertificate=true;";
            opcaoDeConstrucao.UseSqlServer(config);
        }
        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            // Configurações adicionais do modelo podem ser feitas aqui, se necessário
            modeloDeConstrucao.Entity<Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);
            });
        }
    }
}
