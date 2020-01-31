using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class BusinessAccount : Account
    {
        public Double LoanLimit { get; set; }
        
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base (number,holder,balance) {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount >= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
