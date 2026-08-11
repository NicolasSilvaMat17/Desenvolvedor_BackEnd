// Declaração de variaveis
double ladoA_x, ladoB_x, ladoC_x;
double ladoA_y, ladoB_y, ladoC_y;
double perimetro_x, perimetro_y;
double area_X, area_Y;

// Entrada de dados
Console.WriteLine("Entre com as medidas do triângulo X");
Console.Write("Lado A: ");
ladoA_x = double.Parse(Console.ReadLine());
Console.Write("Lado B: ");
ladoB_x = double.Parse(Console.ReadLine());
Console.Write("Lado C: ");
ladoC_x = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triângulo Y");
Console.Write("Lado A: ");
ladoA_y = double.Parse(Console.ReadLine());
Console.Write("Lado B: ");
ladoB_y = double.Parse(Console.ReadLine());
Console.Write("Lado C: ");
ladoC_y = double.Parse(Console.ReadLine());

//Processamento de dados
// Perímetro dos triângulos
perimetro_x = (ladoA_x + ladoB_x + ladoC_x) / 2;
perimetro_y = (ladoA_y + ladoB_y + ladoC_y) / 2;

// Área dos triângulos (usando a fórmula de Heron)
area_X = Math.Sqrt(perimetro_x * (perimetro_x - ladoA_x) * (perimetro_x - ladoB_x) * (perimetro_x - ladoC_x));
area_Y = Math.Sqrt(perimetro_y * (perimetro_y - ladoA_y) * (perimetro_y - ladoB_y) * (perimetro_y - ladoC_y));

// Saída de dados
Console.WriteLine($"Área do triângulo X: {area_X}");
Console.WriteLine($"Área do triângulo Y: {area_Y}");
Console.WriteLine(area_X > area_Y ? "Maior área é X" : "Maior área é Y");