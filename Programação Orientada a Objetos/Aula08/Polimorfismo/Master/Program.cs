using Master.Classe.Entidades;
using Master.Enumeracoes;

//Conta contaNicolas = new Conta("Nicolas", 123456, 1000);
//Conta contaClodoaldo = new ContaPoupanca("Clodoaldo", 123456, 1000);
//Conta senai = new ContaEmpresa("Mange", 123456, 1000);

// Declaração de variáveis
Conta conta;
string titular;
int numero;
double saldo, limite, taxa;

// Entrada de dados 
Console.WriteLine("Deseja abrir qual tipo de conta: " +
    "\n1 - Conta pessoa física" +
    "\n2  - Conta poupança" +
    "\n3 - Conta empresa");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        break;
    case 2:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Poupanca}");
        AbrirPoupanca();
        break;
    case 3:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        break;
    default:
        Console.WriteLine("Nenhuma opção selecionada");
        conta = null;
        break;
}

Console.WriteLine();
conta.ExibirDados();

void AbrirConta()
{
    Console.WriteLine("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write("Deseja fazer depósito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new Conta(titular, numero, saldo);
    }
    else
    {
        conta = new Conta(titular, numero);
    }
}

void AbrirPoupanca()
{
    Console.WriteLine("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write($"Taxa da conta: ");
    taxa = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaPoupanca(titular, numero, saldo, taxa);
    }
    else
    {
        conta = new ContaPoupanca(titular, numero, taxa);
    }
}

void AbrirEmpresa()
{
    Console.WriteLine("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write($"Limite da conta: ");
    limite = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaEmpresa(titular, numero, saldo, limite);
    }
    else
    {
        conta = new ContaEmpresa(titular, numero, limite);
    }
}

