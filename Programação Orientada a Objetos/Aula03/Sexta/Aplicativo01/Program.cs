// Declaração de variáveis 
using Aplicativo01;

Calculadora calculadora;
double raio;

// Entrada de dados
Console.Write("Entre com o valor do raio da circunferecia");
raio = double.Parse(Console.ReadLine());

// Instanciação do objeto
calculadora = new Calculadora(raio);

// Processamento de dados 


// Saida de dados 
Console.WriteLine($"Circunferência : {calculadora.Circunferencia():f2}" +
    $"Volume: {calculadora.Volume():f2}");
calculadora.PI();