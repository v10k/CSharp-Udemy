using Exercicio_1.Entities;
using Exercicio_1.Services;
using System;
using System.Globalization;

namespace Exercicio_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double cValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, cValue);
            ContractService cService = new ContractService(new PaypalTax());
            cService.ProcessContract(installments, contract);

            Console.WriteLine("INSTALLMENTS");
            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }
            
        }
    }
}
