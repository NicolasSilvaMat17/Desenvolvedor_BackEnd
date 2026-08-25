using Aluguel.Classes.Entidades;
using Aluguel.Classes.Servicos;
using Aluguel.Interfaces;
                                                                                                            
Console.WriteLine("Locaçaõ de veículo");
Console.Write("Modelo do carro: ");
string modelo = Console.ReadLine();
Console.Write("Retiada(dd/MM/yyyy hh:mm): ");
DateTime retirada = DateTime.Parse(Console.ReadLine());
Console.Write("Devolução(dd/MM/yyyy hh:mm): ");
DateTime devolucao = DateTime.Parse(Console.ReadLine());

AluguelCarro aluguel = new AluguelCarro(retirada, devolucao, modelo);

Console.Write("Informe o valor por hora: ");
double preco1 = double.Parse(Console.ReadLine());
Console.Write("Informe o valor por dia: ");
double preco2 = double.Parse(Console.ReadLine());

ItaxaServ taxa = new TaxaServBasil();

ServAluguel aluguelServ = new ServAluguel(preco1, preco2, taxa);

aluguelServ.CalcularFatura(aluguel);

Console.WriteLine(aluguelServ   .ToString());