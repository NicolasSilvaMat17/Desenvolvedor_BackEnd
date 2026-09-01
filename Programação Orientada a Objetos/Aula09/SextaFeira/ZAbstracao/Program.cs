using System;
using System.Collections.Generic;
using System.Globalization;
using ZAbstracao.Entidades;

namespace ZAbstracao
{
    internal class Program
    {
        static void Main()
        {
            var culture = CultureInfo.InvariantCulture;

            Console.Write("Quantos contribuintes? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Entrada inválida. Digite um número inteiro maior que zero: ");
            }

            var lista = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Contribuinte #{i} - Tipo (f/j): ");
                var tipo = (Console.ReadLine() ?? "").Trim().ToLower();

                Console.Write("Nome: ");
                var nome = Console.ReadLine() ?? string.Empty;

                Console.Write("Renda anual: ");
                var renda = double.Parse(Console.ReadLine() ?? "0", culture);

                if (tipo == "f")
                {
                    Console.Write("Gastos com saúde: ");
                    var gastos = double.Parse(Console.ReadLine() ?? "0", culture);
                    lista.Add(new PessoaFisica(nome, renda, gastos));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    var funcs = int.Parse(Console.ReadLine() ?? "0");
                    lista.Add(new PessoaJuridica(nome, renda, funcs));
                }
            }

            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS:");
            double total = 0;

            foreach (var p in lista)
            {
                var imposto = p.CalcularImposto();
                Console.WriteLine($"{p.Nome}: R$ {imposto.ToString("F2", culture)}");
                total += imposto;
            }

            Console.WriteLine($"TOTAL DE IMPOSTO: R$ {total.ToString("F2", culture)}");
        }
    }
}
