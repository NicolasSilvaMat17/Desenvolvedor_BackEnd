// Declaração de variaveis

const int senha = 2002;

// Entrada de ddados
Console.WriteLine("Digite a senha: ");
int n = int.Parse(Console.ReadLine());

while (senha != n)
{
    Console.Write("Senha Invalida, tente novamente: ");
    n = int.Parse(Console.ReadLine());
    int++;
    Console.WriteLine("Número de tentativas");
}
Console.WriteLine("Acesso permitido!");