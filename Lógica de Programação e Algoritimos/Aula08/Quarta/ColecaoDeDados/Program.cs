// Coleção de dados
/* -- Arrays -- */
int[] numeros = { 0, 1, 2, 10, 4 }; // Declaraçãp e inicialização de um array de inteiros
string[] nomes = { "Ana", "Bia", "Carlos" }; // Declaração e inicialização de um array de strings
char[] caracteres;

Console.WriteLine(numeros.Length); // Retorna o tamanho do array
Console.WriteLine(numeros[3]);
numeros[3] = 56;
Console.WriteLine(numeros[3]);
caracteres = new char[10]; 

/* -- Dicionários -- */
Dictionary<string, double> salarios = new Dictionary<string, double>() // Declaração de um dicionário
{
    { "Alice", 1.73 },
    { "Bob", 62.9 },
    { "Clodoaldo", 14}
};

Console.WriteLine(salarios["Bob"]); // Retorna o valor associado à chave "Bob"
salarios.Add("SENAI", 8.96); // Adiciona um novo par chave-valor ao dicionário
Console.WriteLine(salarios["SENAI"]);
salarios.Remove("Alice"); // Remove o par chave-valor associado à chave "Alice"

foreach (var item in salarios) // Itera sobre os pares chave-valor do dicionário
{
    Console.WriteLine(item.Key + " tem " + item.Value);
}

if (salarios.ContainsKey("Bob"))
{
    Console.WriteLine("Bob está na coleção"); 
} 

/* -- Listas -- */

List<int> lista1 = new List<int>();
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);
Console.WriteLine(lista1);
foreach (var item in lista1)
{
    Console.WriteLine(item);
}
lista1.Insert(2, 900); // Insere o valor 900 na posição 2 da lista
lista1.Remove(600); // Remove o valor 600 da lista

foreach (var item in lista1)
{
    Console.WriteLine(item);
} 

/* -- Tuplas -- */ // permite agrupar diferentes tipos de dados em uma única estrutura, não tem tamanho dinamico
var pessoa = ("João", 30, 1.75, 'M'); // Declaração e inicialização de uma tupla
Console.WriteLine(pessoa.Item1); // Nome
Console.WriteLine(pessoa.Item2); // Idade
Console.WriteLine(pessoa.Item3); // Salario
Console.WriteLine(pessoa.Item4); // Gênero


