using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02BankАccounts.Customers;

namespace Problem02BankАccounts.Accounts
{
    abstract class Account
    {
        protected Customer Holder { get; set; }
        protected decimal Balance { get; set; }
        protected decimal InterestRate { get; set; }

        public Account(Customer holder, decimal balance, decimal interestRate)
        {
            this.Holder = holder;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public virtual decimal CalculateInterest(int months)
        {
            return InterestRate * months;
        }

    }
}
