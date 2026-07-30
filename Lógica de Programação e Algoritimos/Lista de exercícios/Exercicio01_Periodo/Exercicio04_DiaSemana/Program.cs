// Declaração de variáveis 

int numero;

try
{

    Console.WriteLine("Informe um número de 1 a 7: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 1)
    {
        Console.WriteLine("1-Domigo");

    }
    else if (numero == 2)
    {
        Console.WriteLine("2-Segunda");
    }
    else if (numero == 3)
    {
        Console.WriteLine("3-Terça");
    }
    else if (numero == 4)
    {
        Console.WriteLine("4-Quarta");
    }
    else if (numero == 5)
    {
        Console.WriteLine("5-Quinta");
    }
    else if(numero == 6)
    {
        Console.WriteLine("6-Sexta");
    }
    else if (numero == 7)
    {
        Console.WriteLine("7-Sábado");
    }
    else
    {
        Console.WriteLine("Valor inválido");
    }
}
catch
{
    Console.WriteLine("Ocorreu um erro");
}
