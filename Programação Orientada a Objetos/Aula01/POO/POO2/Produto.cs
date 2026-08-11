namespace POO2
{
    internal class Produto
    {
        // Campos   
        public string nome;
        public double preco;
        public int quantidade;

        // Metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto: {nome}\n" +
                $"Valor da compra: {preco}\n" +
                $"Quantidade em estoque: {quantidade}\n" +
                $"Valor total em estoque: {ValorEmEstoque():c}");
        }

        public void AdicionarProdutos( int q)
        {
            quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            quantidade -= q;
            
        }

        public double ValorEmEstoque()
        {
            return quantidade * preco;
        }
    }
}