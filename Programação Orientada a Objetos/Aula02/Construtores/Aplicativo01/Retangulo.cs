
namespace Aplicativo01
{
    public class Retangulo
    {

        // Campos
        double largura;
        double altura;

        // Construtor
        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        // Métodos
        public double Area()
        {
            return largura * altura;
        }
        public double Perimetro()
        {
            return 2 * (largura + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Valores digitados foram:\n" +
                $"Largura: {largura}\n " +
                $"Altura: {altura}\n " +
                $"Área: {Area()}\n " +
                $"Perímetro: {Perimetro()}\n " +
                $"Diagonal: {Diagonal()}");
        }
    }
}