using Abstracao.Enumeracoes;
using Abstracao.Inerfaces;

namespace Abstracao.Classes.Entidades
{
    abstract internal class Forma : IGeometria
    {
        Cor cor;

        // Contrutor
        public Forma(Cor cor)
        {
            this.cor = cor;
        }

        /// <summary>
        /// Método para calcular a área da forma.
        /// </summary>
        // Método
        public abstract void Area(); // aplicou o método de forma abstrata 

        public string Cor() => (cor.ToString());
    }
}
    