namespace Triangulo_Com_POO
{
    internal class Triangulo
    {
        //Membro
        // 1° Membro: Campos
        public double a, b, c;

        // 2° Membro: Métodos
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
        }
    }
}
