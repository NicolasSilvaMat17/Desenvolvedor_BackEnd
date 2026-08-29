using Abstracao.Enumeracoes;

namespace Abstracao.Classes.Entidades
{
    internal class Retangulo : Forma
    {

        private double  largura;
        private double altura;


        // Propriedades
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double  Largura
        {
            get { return largura; }
            set { largura = value; }
        }


        // Contrutor
        public Retangulo(Cor cor, double largura, double altura) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        // Método
        public override void Area()
        {
            Console.WriteLine(Largura * Altura); 
        }
    }
}
