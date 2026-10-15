namespace APIPessoas.Models.Entidades
{
    public class Produtos
    {
        // Propriedades da classe Produtos
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        // Construtor padrão
        public Produtos(string nome, decimal preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}
