// Declaração de variáveis 
double salarioBruto;
double salarioLiquido;
double iRenda = 0.5;
double INSS = 0.1;
double FGTS = 0.11;
double descontos;
double salarioHora;
double quantidadeHora;

//Entrada de dados
try
{
    Console.WriteLine("Informe o valor do salario hora: ");
    salarioHora = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe as horas trabalhadas");
    quantidadeHora = double.Parse(Console.ReadLine());

    salarioBruto = salarioHora * quantidadeHora;

    if (salarioBruto <= 900)
    {
        iRenda = 0;
    }
    else if (salarioBruto > 900.00 && salarioBruto <= 1500.00)
    {
        iRenda = 0.05;
    }
    else if (salarioBruto > 1500.00 && salarioBruto <= 2500.00)
    {
        iRenda = 0.10;
    }
    else

    {
        iRenda = 0.20;
    }
    Holerite();

    Console.Write($"Sálário Bruto R$: {salarioBruto:f2}");
    Console.Write($"\n(-)IR R$: {salarioBruto * iRenda:f2}");
    Console.Write($"\n(-)INSS R$: {salarioBruto * INSS:f2} ");
    Console.Write($"\nFGTS R$: {salarioBruto * FGTS:f2}");
    Console.Write($"\nTotal de descontos R$: {descontos:f2}");
    Console.Write($"\nSalário Liquido R$: {salarioLiquido:f2}");



}
catch
{
    Console.WriteLine("Valor Inválido");
}


void Holerite()
{
    descontos = (salarioBruto * iRenda) + (salarioBruto * INSS);
    salarioLiquido = salarioBruto - descontos;
}

