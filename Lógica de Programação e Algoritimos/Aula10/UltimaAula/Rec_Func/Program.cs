// Entrada de dados
Console.Write("Base do retângulo: ");
double baseR = double.Parse(Console.ReadLine());

Console.Write("Altura do retângulo: ");
double alturaR = double.Parse(Console.ReadLine());

// Processamento de dados
double area = Area(baseR, alturaR);
double perimetro = Perimetro(baseR, alturaR);
double diagonal = Diagonal(baseR, alturaR);

// Saída de dados
Console.WriteLine($"Área = {area}, Perímetro = {perimetro}, Diagonal = {diagonal}");


// Funções
double Area(double b, double a)
{
    return b * a;
}

double Perimetro(double b, double a)
{
    return 2 * (b + a);
}

double Diagonal(double b, double a)
{
    return Math.Sqrt(b * b + a * a);
}
