using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
using System.Configuration;

namespace SistemaERP.Classes.Contexto
{
    internal class ContextoUsuario : DbContext
    {
        public DbSet<usuario> Usuarios { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319387\SQLEXPRESS01;Database=dbevback;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NomeDoUsuario);
                entidade.Property(e => e.SenhaDoUsuario);
                entidade.Property(e => e.Regra);

            }
        );
        }
    }
}