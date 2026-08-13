using Aplicativo02;
// Declaração de variáveis
string nome;
double salarioBruto;
double imposto;

// Entrada de dados
Console.Write("Dados do fucionário");
Console.Write("Digite o nome do funcionário: ");
nome = Console.ReadLine();
Console.Write("Digite o salário bruto: ");
salarioBruto = double.Parse(Console.ReadLine());
Console.Write("Digite o imposto: ");
imposto = double.Parse(Console.ReadLine());

Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);
funcionario.ExibirDados();
Console.WriteLine($"Digite a porcentagem do aumento do salário:");
double porcentagem = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagem);
Console.Write("Dados atualizados");
funcionario.ExibirDados();

Console.WriteLine();
Console.ReadKey();