// Entrada de dados
Console.Write("Digite a medida A: ");
double a = double.Parse(Console.ReadLine());    
Console.Write("Digite a medida B: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de C: ");
double c = double.Parse(Console.ReadLine());

// Processamento de dados
Console.WriteLine(Delta(a, b, c));

double Delta(double q, double w, double e) // Função para calcular o delta
{
    double delta; // Declaração da variável delta
    delta = (w * w) - 4 * q * e; 
    return delta;
}

