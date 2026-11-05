using System.ComponentModel.DataAnnotations;

namespace UltimaAula.Models.Entidades
{
    public class Usuario
    {
        // Propriedades
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3), MaxLength(20)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(6), MaxLength(100)]
        public string Senha { get; set; }
        [Required]
        
        public string Regra { get; set; }

        // Construtor
        public Usuario(string nome, string senha, string regra)
        {   
            Nome = nome;
            Senha = senha;
            Regra = regra;
        }

    }
}
