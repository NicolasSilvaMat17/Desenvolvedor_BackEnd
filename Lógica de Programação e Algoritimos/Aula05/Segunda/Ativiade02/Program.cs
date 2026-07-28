// Declaração de variáveis
double a, b, c, perimetro, trapezio;
Console.WriteLine("Digite a medida de A: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida de B: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida de C");
c = double.Parse(Console.ReadLine());


try
{
    if (a + b > c && b + c > a | c + a > b)
    {
        // Processamento de dados 
        AreaTriangulo();


        // Saída de dados
        Console.WriteLine($"O perímetro é {perimetro:f1}");
    }
    else

    {
        AreaTrapezio();
        Console.WriteLine($"A área do trapézio é {trapezio:f1} ");
    }
} 
catch
{
    Console.WriteLine("Digite valores válidos: ");
}
double AreaTriangulo()
{
    perimetro = a + b + c;
    return perimetro;
}
double AreaTrapezio()
{
    trapezio = ((a * b) * c) / 2;
    return trapezio;
}