using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
namespace SistemaERP.Classes.Contexto
{
    internal class ContextoUltimoUsuario : DbContext
    {
        public DbSet<UltimoUsuario> ultimoUsuarios { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Data Source=UltimoUsuarioLogado.db";
            opcoesDeConstrucao.UseSqlite(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<UltimoUsuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Senha);

                entidade.Property(e => e.EsqueceuSenha);

            }

        );
        }


    }
}
