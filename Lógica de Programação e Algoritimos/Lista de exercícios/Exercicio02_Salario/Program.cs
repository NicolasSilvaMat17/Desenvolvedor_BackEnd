using static System.Console;
// Declaração de variaveis
double salario;
double aumento;
double percentual;
double salarioNovo;

// Entrada de dados
try
{
    Console.Write("Digite o salário do funcionário: ");
    salario = double.Parse(Console.ReadLine());

    if (salario <= 280)
    {
        percentual = 20;
        Calculos();
    }
    else if (salario <= 280 && salario <= 700)
    {
        percentual = 15;
        Calculos();
    }
    else if (salario <= 700 && salario <= 1500)
    {
        percentual = 10;
        Calculos();
    }
    else
    {
        percentual = 5;
        Calculos();
    }
    // Saída de dados
    Console.WriteLine($"Salário antes do ajuste: {salario:f2}");
    Console.WriteLine($"Percentual do aumento aplicado: {percentual}%");
    Console.WriteLine($"Valor do aumento: {aumento:f2}");
    Console.WriteLine($"O novo salário, após o aumento: {salarioNovo:f2}");
}
catch
{
    Console.WriteLine("Valor inválido!");
}
ReadKey();

void Calculos()
{
    aumento = salario * percentual / 100;
    salarioNovo = salario + aumento;
}