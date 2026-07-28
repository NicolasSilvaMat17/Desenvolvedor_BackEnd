const string janela = "Problema medidas";
Console.Title = janela;

// Declaração de variáveis
double a, b, c, quadrado, triangulo, trapezio;

// Entrada de dados
Console.WriteLine("Digite a medida A: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida B: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida de C: ");
c = double.Parse(Console.ReadLine());

// Processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

// Saída de dados
Saida();

Console.ReadKey();

double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}
void Saida()
{
    Console.WriteLine($"Área do quadrado: {quadrado:f4}\n");
    Console.WriteLine($"Área do triângulo: {triangulo}\n"); 
    Console.WriteLine($"Área do trapézio: {trapezio}");
}
