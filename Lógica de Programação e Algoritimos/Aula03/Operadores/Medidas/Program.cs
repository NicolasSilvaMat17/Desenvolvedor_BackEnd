using static System.Console;

try
{
    // Declaração de variáveis
    int a, b, c;
    double area_q, area_t, area_tp;

    // Entada de dados
    Write("Digite o valor de A: ");
    a = int.Parse(ReadLine());
    Write("Digite o valor de B: ");
    b = int.Parse(ReadLine());
    Write("Digite o valor de C: ");
    c = int.Parse(ReadLine());

    // Processamento de dados
    area_q = Math.Pow(a, 2);
    area_t = (a * b) / 2;
    area_tp = ((a + b) * c) / 2;

    // Saída de dados
    WriteLine($"Área do quadrado: {area_q:f4}");
    WriteLine($"Área do triângulo: {area_t:f4}");
    WriteLine($"Área do trapézio: {area_tp:f4}");
}
catch // Bloco catch para tratar exceções
{
    WriteLine("Digite um valor válido");
}
finally // Bloco finally para encerrar o programa
{
    WriteLine("Encerrando programa");
}