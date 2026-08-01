// Declaração de variáveis
Console.Write("Quantos números você vai digitar: ");
int n = int.Parse(Console.ReadLine());

// Controle de repetição
for (int i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Negativo");
    }
    else if (numero == 0)
    {
        Console.WriteLine("Nulo");
        continue;
    }
    {
        Console.WriteLine("Positivo");
    }

    if (numero % 2 > 0)
    {
        Console.WriteLine("Par");

    } 
    else
    {
        Console.WriteLine("Impar");
    }
}