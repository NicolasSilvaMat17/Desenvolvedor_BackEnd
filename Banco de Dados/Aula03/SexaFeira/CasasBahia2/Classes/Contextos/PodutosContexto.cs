using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Contextos
{
    internal class ProdutosContexto : DbContext
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
            modeoDeCostrucao.Entity<Logins>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Usuario);
                entidade.Property(e => e.Senha);
                entidade.Property(e => e.Regra);
            });
        }
    }
}
