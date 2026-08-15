namespace Moeda
{
    internal static class Dolares
    {
        // Membros de uma classe
        // 1° Campo
        public static double dolares;

        // 3° metodos
        public const double IOF = 0.06;

        public static double Comprar(double cotacao, double compra)
        {
            double pagamento = (cotacao * compra * (1 + IOF));
            return pagamento;
        }
    }

}