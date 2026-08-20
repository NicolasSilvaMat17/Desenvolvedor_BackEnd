using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class Funcionario
    {
		// Campos
		private string  nome;
		private List<HoraContrato> contratos;

		// Propriedades
        protected string  Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		protected List<HoraContrato> Contratos
		{
			get { return Contratos; }
			set { Contratos = value; }
		}

		// Costrutor
        public Funcionario(string nome)
        {
            Nome = nome;
        }

		// Metodos
		public void AdiconarContrato(double valor, int horas)
		{
			HoraContrato contrato = new HoraContrato(horas, valor);
			Contratos.Add(contrato);
		}
	}
}
