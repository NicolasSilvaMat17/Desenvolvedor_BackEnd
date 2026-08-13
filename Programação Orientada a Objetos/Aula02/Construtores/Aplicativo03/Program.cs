using Aplicativo03;

// Declaração de variáveis

string nome;
double nota1;
double nota2;
double nota3;

// Entrada de dados
Console.Write("Digite o nome do aluno: ");
nome = Console.ReadLine();
Console.Write("Digite a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.Write("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

Aluno aluno = new Aluno(nome, nota1, nota2, nota3);
aluno.ExibirDados();

Console.WriteLine();
Console.ReadKey();