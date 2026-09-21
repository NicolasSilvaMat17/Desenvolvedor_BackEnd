using Cars.Classes.Contextos;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.IdentityModel.Tokens;
using Cars.Classes.Entidades;

namespace Cars.Classes.Services
{
    internal class Pesquisa
    {
        // Campo
        static EstoqueContexto contexto = new EstoqueContexto();


        // Métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1, string filtro)
        {
            if (moto.Equals(false) & carro.Equals(false) | moto.Equals(true) & carro.Equals(true))
            {
                Filto(texto, dataGridView1);
            }
            else if (moto)
            {
                // Pesquisa por motos no banco de dados e exibe os resultados no DataGridView.
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 1));
            }
            else if (carro)
            {
                // Pesquisa por carros no banco de dados e exibe os resultados no DataGridView.
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 2));
               
            }
        }

        private static void Filto(string texto, DataGridView dataGridView1, string filtro)
        {
            if (texto.IsNullOrEmpty())
            {
                // Pesquisa todos os itens no banco de dados e exibe os resultados no DataGridView.
                dataGridView1.DataSource = Projetar(contexto.Estoque);
            }
            else if (filtro.Equals("Contém"))
            {
                // Pesquisa por modelo no banco de dados e exibe os resultados no DataGridView.
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
            }
            else if (filtro.Equals("Inicia"))
            {
                // Pesquisa por modelo no banco de dados e exibe os resultados no DataGridView.
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.StartsWith(texto)));
            }
        }
            
        /// <summary>
        /// Método auxiliar responsável pela projeção em todas as pesquisas.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        private static object Projetar(IQueryable<Estoque> consulta)
        {
            return consulta.Select(e => new
            {
                e.Tipo,
                e.Modelo,
                e.Quantidade,
                Valor = e.Valor.ToString("C")
            }).ToList();
        }


    }
}
