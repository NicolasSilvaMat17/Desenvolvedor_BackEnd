namespace Estoque
{
    internal class Produto
    {
        // Campos
        string nome;
        int quantidade;
        double preco;

        // Construtor
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public Produto(string nome, int quantidade, double preco)
        { 
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }
        // Métodos
        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }

        public double ValorTotal()
        {
            return quantidade * preco;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}," +
                $" Quantidade: {quantidade}, " +
                $"Preço: R$ {preco:F2}, " +
                $"Total: R$ {ValorTotal():c}");
        }
    }
}