using System;
using Delegate_predicate.Entitites;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_predicate {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(ProductTest);
            //list.RemoveAll(p => p.Price >= 100.00);

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //list.ForEach(act);

            //foreach (Product p in list) {
            //    Console.WriteLine(p);
            //}

            //List<string> result = list.Select(NameUpper).ToList();
            Func<Product, string> func = NameUpper;
            List<string> result = list.Select(func).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }

        }

        static bool ProductTest(Product p) {
            return p.Price >= 100;
        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}
