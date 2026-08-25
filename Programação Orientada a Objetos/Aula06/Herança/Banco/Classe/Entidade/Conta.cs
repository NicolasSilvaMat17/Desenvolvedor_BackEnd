using Banco.Interfaces;

namespace Banco.Classe.Entidade
{
    internal class Conta : IOperacoes
    {
		// Campos
		private int numero;
		private string titular;
		private double saldo;

        // Propriedades
        protected int NumeroDaConta
		{
			get { return numero; }
			set { numero = value; }
		}
		protected string TitularDaConta
		{
			get { return titular; }
			set { titular = value; }
		}
		protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		// Construtor
        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
			SaldoDaConta = 0;
        }
        public Conta(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }
        // Metodos
        public virtual void Saque(double quantia)
        {
            const double taxaSaque = 5.00;
            SaldoDaConta -= quantia + taxaSaque;
        }

        public  void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public override string ToString()
        {
            return $"Dados da conta: \n" +
                $"\t Titular da Conta: {TitularDaConta}\n" +
                $"\t Saldo da Conta: {SaldoDaConta:F2}";
        }
    }
}
