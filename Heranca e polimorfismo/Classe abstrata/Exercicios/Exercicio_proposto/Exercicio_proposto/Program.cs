using System;
using Exercicio_proposto.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_proposto {
    class Program {
        static void Main(string[] args) {
            List<Pessoa> list = new List<Pessoa>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer {i} data:");
                
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, income, healthExpeditures));
                } else {
                    Console.Write("Number of employees: ");
                    int NEmpregados = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, income, NEmpregados));
                }
            }

            double sum = 0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach (Pessoa item in list) {
                Console.WriteLine($"{item.Nome}: $ {item.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += item.CalculaImposto();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum}");
        }
    }
}
