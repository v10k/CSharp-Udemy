﻿using System;
using System.Collections.Generic;
using Exercicio_proposto.Entities;
using System.Globalization;

namespace Exercicio_proposto {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                } else if(c == 'u') {
                    Console.Write("Manufacture data (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                } else {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS: ");
            foreach (Product item in list) {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
