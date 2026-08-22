namespace Banco.Classe.Entidade
{
    internal class ContaEmpresa : Conta
    {
		// Campos
		private double limite;


        // Propriedades
        protected double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}

		// Construtores
        public ContaEmpresa(int numeroDaConta, string titularDaConta, double limite ) : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        // Metodos
        public override string ToString()
        {
            return $"Dados da conta: \n" +
                $"\t Titular da Conta: {TitularDaConta}\n" +
                $"\t Saldo da Conta: {SaldoDaConta}\n" +
                $"\tLimite: {LimiteDeEmprestimo}";
        }

        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }

	}
}
