using ZAbstracao.Enumeracoes;
using ZAbstracao.Classes.Servicos;

namespace ZAbstracao.Entidades
{
    internal class PessoaJuridica : Pessoa
    {
        // Campo
        private int numeroFuncionario;

        // Propriedade
        public int NumeroFuncionarios
        {
            get { return numeroFuncionario; }
            set { numeroFuncionario = value; }
        }

        // Construtor
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual, TipoPessoa.Juridica)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }


        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Renda anual: R$ {RendaAnual:F2}");
            Console.WriteLine($"Número de funcionários: {NumeroFuncionarios}");
        }

        public override double CalcularImposto()
        {
            var servico = new Imposto();
            return servico.CalcularImpostoPessoaJuridica(this);
        }
    }

}
