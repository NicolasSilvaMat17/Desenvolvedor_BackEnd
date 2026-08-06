// Declaração de variáveis
double[] numeros;
double valores, soma, media;
int n;

try
{
    // Entrada de dados
    Console.Write("Quantos números você vai digitar? ");
    n = int.Parse(Console.ReadLine());
    numeros = new double[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um número: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

        Console.Write($"Valores = ");
    foreach (var item in numeros)
    {
        Console.Write($"{item} ");
    }
    media = numeros.Average();
    soma = numeros.Sum();
    Console.WriteLine($"\nSoma = {soma}" +
        $"\nMedia = {media:f2}");
}
catch (Exception e)
{
    Console.WriteLine($"Valor inválido, erro: {e}");
}
