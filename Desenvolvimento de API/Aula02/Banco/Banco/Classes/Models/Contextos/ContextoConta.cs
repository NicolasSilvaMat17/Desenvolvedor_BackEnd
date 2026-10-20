using Banco.Classes.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Classes.Models.Contextos
{
    public class ContextoConta : DbContext
    {
        

        public DbSet<ContaBancariacs> contasBancarias { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "Data Source=ContasBancarias.db";
            opcoesDeConstrucao.UseSqlite(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<ContaBancariacs>(entidade =>
            {
                entidade.HasKey(e => e.NumeroConta);

                entidade.Property(e => e.TitularConta);

                entidade.Property(e => e.Saldo);

            }

        );
        }


    }
}
