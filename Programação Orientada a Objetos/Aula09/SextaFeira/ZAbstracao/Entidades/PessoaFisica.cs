using ZAbstracao.Enumeracoes;
using ZAbstracao.Classes.Servicos;

namespace ZAbstracao.Entidades
{
    internal class PessoaFisica : Pessoa
    {
        // Campos
        private double gastosSaude;

        // Propriedades
        public double GastosSaude
        {
            get { return gastosSaude; }
            set { gastosSaude = value; }
        }

        // Construtor
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual, TipoPessoa.Fisica)
        {
            GastosSaude = gastosSaude;
        }

        // Métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Renda anual: R$ {RendaAnual:F2}");
            Console.WriteLine($"Gastos com saúde: R$ {GastosSaude:F2}");
        }

        public override double CalcularImposto()
        {
            var servico = new Imposto();
            return servico.CalcularImpostoPessoaFisica(this);
        }

    }
}