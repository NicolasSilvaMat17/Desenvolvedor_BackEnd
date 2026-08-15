// Declaração de variáveis
using Moeda;
double dolar, cotacao, reais;

// Entrada de dados 
Console.WriteLine("Digit a cotação do dólar: ");
cotacao = double.Parse(Console.ReadLine());
Console.WriteLine("Quantos sólares você vai comprar? ");
dolar = double.Parse(Console.ReadLine());

Console.WriteLine($"Valor a ser pago em reais = {Dolares.Comprar(cotacao, dolar):c}");