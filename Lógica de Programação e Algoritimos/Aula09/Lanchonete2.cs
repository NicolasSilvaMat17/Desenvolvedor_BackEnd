// Declaração de variáveis
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    { 1, 4.50},
    { 2, 4.50},
    { 3, 5.00},
    { 4, 2.00},
    { 5, 1.50}
};
int codigo, quantidade;
double preco;

while (true)
{
    try
    {
        // Entrada de dados
        Console.WriteLine(""" 
========================================
           CARDÁPIO DA LANCHONETE       
========================================
CÓDIGO | ITEM            | PREÇO       
----------------------------------------
  1    | Cachorro Quente | R$ 4,50     
  2    | X-Salada        | R$ 4,50     
  3    | X-Bacon         | R$ 5,00     
  4    | Torrada Simples | R$ 2,00     
  5    | Refrigerante    | R$ 1,50     
========================================
""");
        Console.Write("Digite o código do produto (ou 0 para sair): ");
        codigo = int.Parse(Console.ReadLine());
        if (codigo == 0)
        {
            Console.WriteLine("Saindo...");
            return;
        }
        else if ( codigo > 5 | codigo < 0)
        {
            Console.WriteLine("Código de produto inválido! Tente novamente.");
            continue;
        }
        Console.Write("Digite a quantidade de produtos: ");
        quantidade = int.Parse(Console.ReadLine());

        async Task pedido()
        {
            Console.WriteLine("Processando pedido...(aguarde)");
            await Task.Delay(2000);
        }
        await pedido();
        // Processamento de dados
        preco = quantidade * produtos[codigo];

        // Saída de dados
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine($"Pedido do produto {codigo} com quantidade {quantidade} registrado com sucesso!");
    }
    catch (Exception e)
    {
        Console.WriteLine("Código de produto inválido! Tente novamente.: " + e);
    }
    finally
    {
        Console.WriteLine("Deseja fazer outro pedido? (S/N)");
        string resposta = Console.ReadLine().ToUpper();
        if (resposta == "N")
        {
            Console.WriteLine("Saindo...");            
        }
    }
}