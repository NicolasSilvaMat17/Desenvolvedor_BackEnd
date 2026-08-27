// Declaração de variáveis
using Pessoas.Clases.Entidades;

int n;
List<Funcionario> listaFuncionarios = new();

// Entada de dados
Console.Write("Deseja registrar quantos funcionários? ");
n = int.Parse(Console.ReadLine());


// Processamento de dados
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Colaborador n° {i + 1}");
    Console.Write("O funcionário é terceirizado (s/n) ? ");
    char escolha = char.Parse(Console.ReadLine());

    Console.Write("Nome do funcionário: ");
    string nome = Console.ReadLine();
    Console.Write("Quantidade de horas trabalhadas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("Valor da hora do funcionário: ");
    double valor = double.Parse(Console.ReadLine());

    if (escolha == 's')
    {
        // Criar umm funcionário terceirizado
        listaFuncionarios.Add(new Terceiro(nome, horas, valor));
    }
    else
    {
        // Criar um funcionário
        listaFuncionarios.Add(new Funcionario(nome, horas, valor));
    }
}

Console.WriteLine("Pagamentos: ");

foreach (var pessoa in listaFuncionarios)
{
    Console.WriteLine($"Nome: {pessoa.NomeFuncionario} - Pagamento: {pessoa.Pagamento()}");
}