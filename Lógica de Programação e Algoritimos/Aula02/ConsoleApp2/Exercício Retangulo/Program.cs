// Declaração de variáveis
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

// Entrada de dados
Console.Write("Digite a base do retângulo (em metros): ");
bAse = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retângulo (em metros): ");
altura = double.Parse(Console.ReadLine());

// Processamento de dados
area = bAse * altura;
perimetro = 2 * (bAse + altura);
diagonal = Math.Sqrt(Math.Pow(bAse, 2) + Math.Pow(altura, 2));

// Saída de dados
Console.WriteLine($"--Dados do Retângulo--\n" +
    $"Área: {area:f2}\n" +
    $"Perímetro: {perimetro:f4}\n" +
    $"Diagonal: {diagonal:n}\n");