using Banco.Classe.Entidade;
using System.Xml;

bool sair = true;
double saldo;
while (sair != false)
{
    Console.WriteLine("Selecione qual tipo de conta deseja abrir: \n" +
    "\t 1 - Conta Normal\n" +
    "\t 2 - Conta Poupança\n" +
    "\t 3 - Conta Empresa\n" +
    "\t 4 - Sair");
    int selecao = int.Parse(Console.ReadLine());

    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado conta normal");
            Console.WriteLine("\nNúmero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTitular da conta: ");
            string titular = Console.ReadLine();

            break;
        case 2:
            Console.WriteLine("Selecionado conta poupança");
            break;
        case 3:
            Console.WriteLine("Selecionado conta empresa");
            break;
        case 4:
            sair = true;
            break;
        default:
            Console.WriteLine("Selecionado nenhuma opção, tente novamente");
            break;
    }
}

void Opcao1(Conta conta)
{
    Console.WriteLine("Deseja fazer depósito incial ? (s/n) ");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        return;
    }
    else if (op == 's')
    {
        Console.WriteLine("Qual valor do deposito inicial ? ");
        double valor = double.Parse(Console.ReadLine());
        conta.Deposito(valor);
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}

