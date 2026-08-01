// Declaração de variáveis
int contagem = 0;
Console.Write("Digite a quantidade de pessoas: ");
int visitantes = int.Parse(Console.ReadLine());

Console.Write("Digite a altura minima permitida (em cm): ");
double altura_minima = double.Parse(Console.ReadLine());
Console.Write("Digite a altura maxima permitida (em cm): ");
double altura_maxima = double.Parse(Console.ReadLine());

try
{
    for (int i = 0; i < visitantes; i++)
    {
        Console.Write("Digite a altura dos visitantes: ");
        double alturaVisitantes = double.Parse(Console.ReadLine());
        if (alturaVisitantes < altura_minima) 
        {
            Console.WriteLine("Altura minima insuficiente");
        }
        else if (alturaVisitantes > altura_maxima)
        {
            Console.WriteLine("A altura está acima do permitido ");
        }
        else
        {
            Console.WriteLine("Acesso permitido");
            contagem++;
        }
        
    }

    Console.Write($"Total de pessoas que podem andar na montanha-russa: {contagem}");
}
catch
{
    Console.WriteLine("Valor invaldo, digite um número inteiro.");
}

