using System;
using System.Globalization;
using Exercicio_proposto.Entities;
using Exercicio_proposto.Entities.Exceptions;

namespace Exercicio_proposto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter account data");
            
            try {
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            } 
            catch (AccountException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }



        }
    }
}
