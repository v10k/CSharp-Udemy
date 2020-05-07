using System;
using System.Collections.Generic;

namespace Exercicio_1.Services {
    class PaypalTax : ITaxPayment {

        private readonly double Fee = 0.02;
        private readonly double Interest = 0.01;

        public double FeeTax(double amount) {
            return amount * Fee;
        }

        public double InterestTax(double amount, double month) {
            return amount * month * Interest;
        }
    }
}
