// Declação de variáveis
int x;

// Entrada de dados 
Console.WriteLine("Digite o valor de X: ");
x = int.Parse(Console.ReadLine());



for (int i = 1; i <= x; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

foreach(int item in x)
{

}