using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Classes.Contexto
{
    internal class ContaContext : DbContext
    {
        // Propriedade - Representa as conta no BD
        public DbSet<Conta> contas { get; set; }
        // Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string config = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=BancoDBContas;Trusted_Connection=True;TrustServerCertificate=True;";
            opcoesDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeContrucao)
        {
            modeloDeContrucao.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id );
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);
            });
        }
    }
}
