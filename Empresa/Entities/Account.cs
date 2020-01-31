using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public Double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public Account() { }

        public void Withdray(double amount) {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
