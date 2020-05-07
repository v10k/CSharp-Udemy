using Interface_4.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interface_4 {
    class Program {
        static void Main(string[] args) {
            
            string path = @"c:\temp\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    // Inverte a ordem da lista
                    list.Reverse();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred " +e.Message);
            }
        }
    }
}
