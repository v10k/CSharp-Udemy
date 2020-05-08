using System;

namespace Topicos_Especiais_2 {
    class Program {
        static void Main(string[] args) {
            DateTime dt = new DateTime(2020, 5, 8, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string str = "Good Morning";
            Console.WriteLine(str.Cut(10));

        }
    }
}
