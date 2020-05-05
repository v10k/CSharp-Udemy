using System;
using System.IO;
using System.Collections.Generic;
using Exercicio_fixacao.Entities;
using System.Globalization;

namespace Exercicio_fixacao {
    class Program {
        static void Main(string[] args) {
            List<Sales> lista = new List<Sales>();
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try {
                
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);
                using (StreamReader sr = File.OpenText(sourceFilePath)) {
                    while (!sr.EndOfStream) {
                        string linha = sr.ReadLine();
                        string[] colunas = linha.Split(", ");
                        lista.Add(new Sales(colunas[0], double.Parse(colunas[1].ToString(), CultureInfo.InvariantCulture), int.Parse(colunas[2])));
                    }
                }
                using (StreamWriter sw = File.CreateText(targetFilePath)) {
                    foreach(Sales item in lista) {
                        sw.WriteLine($"{item.Name}, {item.Balance().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine($"An error occurred {e.Message}");
            }
        }
    }
}
