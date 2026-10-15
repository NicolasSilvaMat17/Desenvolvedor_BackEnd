using Microsoft.EntityFrameworkCore;

namespace APIPessoas.Models.Contextos
{
    public class Produtoscontexto : DbContext
    {
        public DbSet<Entidades.Produtos> Produtos { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "";
            opcoesDeConstrucao.UseSqlite(caminho);
        }

    }
}
