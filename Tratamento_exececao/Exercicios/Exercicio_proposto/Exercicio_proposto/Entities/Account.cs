﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_proposto.Entities.Exceptions;

namespace Exercicio_proposto.Entities {
    class Account {
        public int      Number          { get; set; }
        public string   Holder          { get; set; }
        public double   Balance         { get; set; }
        public double   WithdrawLimit   { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            CheckWithDrawLimit(amount);
            CheckBalanceIsEnough(amount);
            Balance -= amount;
        }

        private void CheckWithDrawLimit(double amount) {
            if (WithdrawLimit < amount) {
                throw new AccountException("The amount exceeds withdraw limit");
            }
        }

        private void CheckBalanceIsEnough(double amount) {
            if (Balance < amount) {
                throw new AccountException("Not enough balance");
            }
        }
    }
}
