using System;
using System.Collections.Generic;
using Exercicio_1.Entities;
using System.Text;

namespace Exercicio_1.Services {
    class ContractService {
        public ITaxPayment _TaxPayment;

        public ContractService(ITaxPayment taxPayment) {
            _TaxPayment = taxPayment;
        }

        public void ProcessContract(int numberInstallments, Contract contract) {
            for (int i = 1; i <= numberInstallments; i++) {
                double amount = contract.TotalValue / numberInstallments;
                amount += _TaxPayment.InterestTax(amount, i);
                amount += _TaxPayment.FeeTax(amount);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), amount));
            }
        }
    }
}
