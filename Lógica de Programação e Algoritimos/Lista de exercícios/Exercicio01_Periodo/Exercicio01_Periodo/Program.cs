// Declaração de variáveis



string M = "Matutino", V = "Vespertino", N = "Noturno";

// Entrada de dados
try
{

    Console.WriteLine("Em qual turno você estuda");
    char periodo = char.Parse(Console.ReadLine());

    // Estrutura condicional para erificar o período
    if (periodo == 'M')
    {
        Console.WriteLine("Bom dia!");
    }
    else if (periodo == 'V')
    {
        Console.WriteLine("Boa tarde!");
    }
    else if (periodo == 'N')
    {
        Console.WriteLine("Boa noite");

    }
    else
    {
        Console.WriteLine("Valor Inválido");
    }
}
catch
{
    Console.WriteLine("Ocorreu um  erro");
}




