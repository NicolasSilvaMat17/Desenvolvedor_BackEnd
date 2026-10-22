
namespace TelaBanco.Classes.DTO
{
    internal class ContaBancariaDTO
    {
        // Propriedades
        public int NumeroConta { get; set; }
        public string TitularConta { get; set; }
        public decimal Saldo { get; set; }

        // Construtor
        public ContaBancariaDTO(string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }
    }
}
