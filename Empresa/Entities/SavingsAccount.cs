﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class SavingsAccount : Account
    {
        public Double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance = Balance * InterestRate;
        }
    }
}
