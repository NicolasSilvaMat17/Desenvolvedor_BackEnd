// DateTime
//TimeSpan
/*
var horario = DateTime.Now;

DateTime data1 = new(1991, 8, 27, 10, 10, 50);
DateTime data2 = new(1993, 6, 7);

var data = data1.AddDays(10);

Console.WriteLine(data.Month);
*/

// Problema "duração"

// Declaração de variáveis
int segundos, minutos, horas;

// Entrada de dados
Console.WriteLine("Digite a duração em segundos:");
int totalSegundos = int.Parse(Console.ReadLine());

// Processamento de dados
horas = totalSegundos / 3600;
minutos = (totalSegundos % 3600) / 60;
segundos = (totalSegundos % 3600) % 60;

// Saída de dados
Console.WriteLine($"{horas}:{minutos}:{segundos}");