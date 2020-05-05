using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao.Entities {
    class Sales {
        public string   Name  { get; set; }
        public double   Price { get; set; }
        public int      Quant { get; set; }

        public Sales(string name, double price, int quant) {
            Name = name;
            Price = price;
            Quant = quant;
        }

        public double Balance() {
            return Price * Quant;
        }
    }
}
