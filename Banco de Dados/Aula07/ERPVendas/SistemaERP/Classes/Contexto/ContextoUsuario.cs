using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
using System.Configuration;

namespace SistemaERP.Classes.Contexto
{
    internal class ContextoUsuario : DbContext
    {
        public DbSet<usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string hostname = "dpg-daoqgcv40ujc7389oe40-a.orgegon-postgres.render.com";
            string porta = "5432";
            string nome_do_banco_de_dados = "dbdeevback";
            string nome_do_usuario = "dbdeevback_user";
            string senha = "GUHWLlYI3hevPtLx13drOvMB2ud5A6G8";

            string string_de_conexao = $"" +
                $"Host = {hostname};" +
                $"Port = {porta};" +
                $"Database = {nome_do_banco_de_dados};" +
                $"Username = {nome_do_usuario};" +
                $"Password = {senha};" +
                $"SSL Mode=Require;" +
                $"Trust Server Certificate=true";
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