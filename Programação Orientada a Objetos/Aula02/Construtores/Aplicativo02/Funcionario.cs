

namespace Aplicativo02
{
    internal class Funcionario
    {
        // Campos
        private string nome;
        private double salarioBruto;
        private double imposto;

        // Construtor
        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }

        // Métodos
        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * porcentagem / 100.0;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Funcionário: {nome}\n" +
                $"Salário Bruto: R$ {salarioBruto:F2}\n" +
                $"Imposto: R$ {imposto:F2}\n" +
                $"Salário Líquido: R$ {SalarioLiquido():c}");
     
        }
    }
}
