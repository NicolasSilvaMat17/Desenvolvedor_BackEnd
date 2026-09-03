using CasasBahia.Classe.Contexto;
using CasasBahia.Classe.Entidade;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu do Almoxarifado --" +
        "\n1. Consultar item no estoque" +
        "\n2. Cadastrar item no estoque" +
        "\n3. Deletar item do estoque" +
        "\n4. Sair");
    Console.Write("Escolha uma opção: ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            // Consulta ao item no estoque
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            { 
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Código de produto não encontrado, código: {codigo}");
            }
            break;
        case 2:
            //  Cadastro do item no estoque
            CadastroDeItem(contexto);
            break;
        case 3:
            // Deletar item do estoque
            DeletarItem(contexto);
            break;
        case 4:
            // Sair do programa
            continuar = false;
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine("-- Cadastro de item --");
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Não permitido cadastro de produto sem nome.");
        return;
    }
    Console.Write("Digite a quantidade do produto: ");
    int qtd = int.Parse(Console.ReadLine());
    if (qtd < 0)
    {
        Console.WriteLine("Não permitido cadastro de produto com quantidade negativa.");
        return;
    }
    Console.Write("Digite o valor do produto: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    if (valor < 0)
    {
        Console.WriteLine("Não permitido cadastro de produto com valor negativo.");
        return;
    }


    Produto produto1 = new Produto(nome, qtd, valor);
    contexto.Produtos.Add(produto1);
    contexto.SaveChanges();
    Console.WriteLine("Produto cadastrado com sucesso!");
}
void DeletarItem(ProdutoContexto produto)
{
    Console.WriteLine("-- Deletar item --");
    Console.Write("Digite o código do produto a ser deletado: ");
    int codigo = int.Parse(Console.ReadLine());
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
    if (codigoProduto != null)
    {
        Console.WriteLine("Deseja realmente deletar o produto? (s/n)");
        string escolha = Console.ReadLine();
        if (escolha.Equals('s'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine($"Produto com código {codigo} deletado com sucesso.");
        }
    }
    else
    {
        Console.WriteLine($"Código de produto não encontrado, código: {codigo}");
    }
}