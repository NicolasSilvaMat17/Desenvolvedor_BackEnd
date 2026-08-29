using ZAbstracao.Enumeracoes;
using ZAbstracao.Interfaces;

namespace ZAbstracao.Entidades
{
    abstract internal class Pessoa : ICalculoImposto
    {
        // Campos
        private string nome;
        private double rendaAnual;
        private TipoPessoa tipo;

        // Propriedades
        public TipoPessoa Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double RendaAnual
        {
            get { return rendaAnual; }
            set { rendaAnual = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        // Construtor
        protected Pessoa(string nome, double rendaAnual, TipoPessoa tipo)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            Tipo = tipo;
        }
        // Métodos
        public abstract double CalcularImposto();
    }
}
