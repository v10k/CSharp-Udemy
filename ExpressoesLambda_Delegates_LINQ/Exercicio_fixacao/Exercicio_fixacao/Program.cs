using System;
using System.Collections.Generic;
using Exercicio_fixacao.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Exercicio_fixacao {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {
                while(!sr.EndOfStream) {
                    string[] employee = sr.ReadLine().Split(",");
                    double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(employee[0], employee[1], salary));
                }
            }

            var emails = list.Where(p => p.Salary > salaryLimit).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " + salaryLimit.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emails) {
                Console.WriteLine(email);
            }
            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " +sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
