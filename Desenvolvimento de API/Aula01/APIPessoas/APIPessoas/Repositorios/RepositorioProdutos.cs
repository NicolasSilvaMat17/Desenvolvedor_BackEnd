using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;

namespace APIPessoas.Repositorios
{
    public class RepositorioProdutos
    {
        // Campo
        private Produtoscontexto contexto = new Produtoscontexto();

        // Propriedade
        public Produtoscontexto Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        // Metodos
        /// <summary>
        /// Método para listar produtos do banco de dados sqlite
        /// </summary>
        /// <returns></returns>
        public List<Produtos> ListarProdutos()
        {
            return contexto.Produtos.ToList();
        }
        /// <summary>
        /// Pesquisa o Id no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Se encontrar o Id retorno o objeto, se não encontrar retorna null</returns>
        public Produtos PesquisarProdutosID(int id)
        {
            var pesquisar = contexto.Produtos.FirstOrDefault(p => p.Id == id);
            return pesquisar;
        }
        /// <summary>
        /// Cria um produto na base de dados
        /// </summary>
        /// <param name="produto"></param>
        /// <example>{ 
        ///     "nome": "TV",
        ///     "preco": 2000,
        ///     "descricao": "Toca Fita",
        /// "quantidade": 10 
        /// }
        /// </example>
        public void CriarProduto(Produtos produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void EditarProduto(Produtos produto)
        {
            Produtos p = PesquisarProdutosID(produto.Id);
            p.Nome = produto.Nome;
            p.Preco = produto.Preco;
            p.Descricao = produto.Descricao;
            p.Quantidade = produto.Quantidade;
            contexto.Update(p);
            contexto.SaveChanges();
        }
    }
}