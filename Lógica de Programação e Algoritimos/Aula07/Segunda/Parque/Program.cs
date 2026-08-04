// Declaração de variáveis
int codigo, veiculo, turistas;
string entrando, saindo;
veiculo = 0;
turistas = 0;
codigo = 0;

while (true)
{

    try
    {
        Console.Write("Digite 1 se o veículo entrando, 2 se o veículo está voltando ou 0 para sair: ");
        codigo = int.Parse(Console.ReadLine());
        if (codigo == 0)
        {
            Console.WriteLine("Encerrando o programa.");
            break;
        }
        Console.Write("Quantas pessoas tem no veiculo?: ");
        turistas = int.Parse(Console.ReadLine());
        if (turistas > 4)
        {
            Console.WriteLine("O veículo não pode ter mais de 4 pessoas.");
            continue;
        }

        if (codigo == 1)
        {
            veiculo += turistas;
            Console.WriteLine($"O veículo entrou com {turistas} pessoas,\n Total de pessoas no parque: {veiculo}");
        }
        else if (codigo == 2)
        {
            veiculo -= turistas;
            Console.WriteLine($"O veículo saiu com {turistas} pessoas,\n Total de pessoas no parque: {veiculo}");
        }
        else
        {
            Console.WriteLine("Código inválido, digite 1 ou 2");
        }

    }
    catch (Exception erro)
    {

        Console.WriteLine($"Valor inválido, erro: {erro}");
    }

}
