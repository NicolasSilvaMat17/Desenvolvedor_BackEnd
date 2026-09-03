namespace CasasBahia.Classe.Entidade
{
    internal class Produto
    {
        // Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        // Construtor
        public Produto(string nomeDoProduto, int quantidadeDeProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDeProduto = quantidadeDeProduto;
            ValorDoProduto = valorDoProduto;
        }

        // Método para exibir informações do produto
        public void ExibirDados()
        {
            Console.WriteLine("-- Dados do Produto --");
            Console.WriteLine($"Código do Produto: {CodigoDoProduto}");
            Console.WriteLine($"Nome do Produto: {NomeDoProduto}");
            Console.WriteLine($"Quantidade do Produto: {QuantidadeDeProduto}");
            Console.WriteLine($"Valor do Produto: {ValorDoProduto:C}");
        }
    }
}
