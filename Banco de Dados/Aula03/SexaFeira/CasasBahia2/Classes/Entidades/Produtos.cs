namespace CasasBahia2.Classes.Entidades
{
    internal class Produtos
    {
        // Propriedades
        public int CodigoDoProduto { get; protected set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProdiuto { get; set; }
        public decimal ValorDoProuto { get; set; }

        // Construtor
        public Produtos(string nomeDoProduto, int quantidadeDeProdiuto, decimal valorDoProuto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDeProdiuto = quantidadeDeProdiuto;
            ValorDoProuto = valorDoProuto;
        }
    }
}
