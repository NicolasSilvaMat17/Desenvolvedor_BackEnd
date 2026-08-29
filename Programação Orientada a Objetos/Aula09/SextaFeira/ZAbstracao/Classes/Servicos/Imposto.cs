using ZAbstracao.Entidades;

namespace ZAbstracao.Classes.Servicos
{
    internal class Imposto
    {

        public  double CalcularImpostoPessoaFisica(PessoaFisica pessoa)
        {
            double imposto;
            if (pessoa.RendaAnual < 20000.00)
            {
                imposto = pessoa.RendaAnual * 0.15;
            }
            else
            {
                imposto = pessoa.RendaAnual * 0.25;
            }

            imposto -= pessoa.GastosSaude * 0.50;
            return imposto;

        }
        public  double CalcularImpostoPessoaJuridica(PessoaJuridica empresa)
        {
            if (empresa.NumeroFuncionarios > 10)
            {
                return empresa.RendaAnual * 0.14;
            }

            return empresa.RendaAnual * 0.16;
        }
    }
}