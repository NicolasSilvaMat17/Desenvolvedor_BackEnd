int primeiroNumero;
int segundoNumero;
int terceiroNumero;


// Entrada de dados
Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
terceiroNumero = int.Parse(Console.ReadLine());

// Processamento
bool resultado1 = primeiroNumero == terceiroNumero;
bool resultado2 = primeiroNumero != segundoNumero;
bool resultado3 = segundoNumero > primeiroNumero;
bool resultado4 = segundoNumero <= terceiroNumero;


// Saída de dados
Console.WriteLine($"O primeiro valor é igual ao terceiro valor? R: {(resultado1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O primeiro número é diferente do segundo valor? R: {(resultado2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O segundo valor é maior que primeiro valor? R: {(resultado3 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O segundo valor é menor ou igual que terceiro valor? R: {(resultado4 ? "Verdadeiro" : "Falso")}");

// Operadores lógicos - Comparação de valores booleanos
bool pergunta1e3 = resultado4 && resultado3;   // 1.Se a pergunta 1 e pergunta 3 são verdadeiros
bool pergunta2ou4 = resultado2 || resultado4;  // 2.Se a pergunta 2 e pergunta 4 pelo menos uma é verdadeiro
bool negacaoPerg1 = !resultado1;               // 3. Se a negação da primeira pergunta é verdadeira

// Saída das respostas
Console.WriteLine("\nPergunta 1 e pergunta 3 são verdadeiras? R: " + pergunta1e3);
Console.WriteLine("Pergunta 2 e pergunta 4 pelo menos uma é verdadeiro? R: " + pergunta2ou4);
Console.WriteLine("negação da primeira pergunta é verdadeira? R: " + negacaoPerg1);
