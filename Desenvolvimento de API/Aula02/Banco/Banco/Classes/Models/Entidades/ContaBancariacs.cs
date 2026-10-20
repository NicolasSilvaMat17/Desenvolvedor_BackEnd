using System.ComponentModel.DataAnnotations;

namespace Banco.Classes.Models.Entidades
{
    public class ContaBancariacs
    {
        /// <summary>
        /// Cria o Numero da cota bancária no database
        /// </summary>
        [Key]
        public int NumeroConta { get; set; }

        /// <summary>
        /// Cria o Titular da conta bancária 
        /// </summary>
        [Required]
        public string TitularConta { get; set; }

        /// <summary>
        /// Saldo da conta, este valor pode ser zero
        /// </summary>
        [Required]
        public decimal Saldo { get; set; }

        // Constructor
        public ContaBancariacs( string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }
    }
}
