// Declaração de variáveis
List<int> numeros = new List<int>();
int n, valor;


try
{
    Console.Write("Quantos números você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    // Loop determinado
    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite u número: ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }

    Console.WriteLine("Números negativos: ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }
    }
}
catch (Exception e)
{

    Console.WriteLine("valor inválido, erro: " + e);
}
