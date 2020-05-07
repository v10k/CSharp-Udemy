using System;
using System.Collections.Generic;

namespace Exercicio_1.Services {
    interface ITaxPayment {
        public double FeeTax(double amount);
        public double InterestTax(double amount, double month);
    }
}
