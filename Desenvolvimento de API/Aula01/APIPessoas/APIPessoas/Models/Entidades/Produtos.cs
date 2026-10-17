using System.ComponentModel.DataAnnotations;

namespace APIPessoas.Models.Entidades
{
    public class Produtos
    {
        // Propriedades da classe Produtos
        public int Id { get; set; }

        [Required(ErrorMessage = "Para cadastrar um produto, o nome é obrigatório")]
        [Length(2, 15, ErrorMessage = "Tamanho mínimo do nome 2 letras e máximo 15 letras")]
        public string Nome { get; set; }

        [Required]
        [Range(0.01, 30000)]
        public decimal Preco { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [Range(0, 100)]
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
