//using System;
//TimeSpan é uma estrutura que representa um intervalo de tempo. Ela pode ser usada para calcular a diferença entre duas datas ou para representar uma duração em horas, minutos e segundos.

// Declaraçãom de variáveis
int totalSegundos, horas, minutos, segundos;

// Entrada de dados
Console.WriteLine("Digite a duração em segundos: ");
totalSegundos = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalSegundos);

// Processamento de dados
horas = (int)duracao.TotalHours;
minutos = duracao.Minutes;
segundos = duracao.Seconds;

// Saída de dados
Console.WriteLine($"{horas}:{minutos}:{segundos}");


