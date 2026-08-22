using System.Runtime.CompilerServices;

namespace Banco.Classe.Entidade
{
    internal sealed class ContaPoupanca : Conta // sealed na classe, não permite herança
    {
		// Campos
		private double taxa;

        // Propriedades
        protected double TaxaDeJuros
		{
			get { return taxa; }
			set { taxa = value; }
		}

        // Construtores
        public ContaPoupanca(int numeroDaConta, string titularDaConta, double taxa) : base(numeroDaConta, titularDaConta) // base é uma chamada da implementação do construtor da superclasse na subclasse
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta, double taxa) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        // Metodos

        public override void Saque(double quantia)
        {
            // Conta poupança: não é cobrada taxa sobre saque
            SaldoDaConta -= quantia;
        }
	}
}
