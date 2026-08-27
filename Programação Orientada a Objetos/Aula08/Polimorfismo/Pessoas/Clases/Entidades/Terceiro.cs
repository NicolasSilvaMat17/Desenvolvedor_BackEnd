namespace Pessoas.Clases.Entidades
{
    internal class Terceiro : Funcionario
    {
		// Campos
		private double despesa;

		// Proopriedade
        protected double DespesaAdicional
		{
			get { return despesa; }
			private set { despesa = value; }
		}

		// Construtor
        public Terceiro(string nomeFuncionario, int jornadaFuncionario, double valorHora) : base(nomeFuncionario, jornadaFuncionario, valorHora)
        {
			DespesaAdicional = (ValorHora * JornadaFuncionario) * 0.2;
        }

		// Método
		public override double Pagamento()
		{
			return base.Pagamento() + DespesaAdicional;
		}
	}
}
