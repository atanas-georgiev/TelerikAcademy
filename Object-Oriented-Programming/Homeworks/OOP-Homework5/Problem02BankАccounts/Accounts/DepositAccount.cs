using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02BankАccounts.Customers;

namespace Problem02BankАccounts.Accounts
{
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (Balance < 1000)
            {
                return 0;
            }
            else
            {
                return InterestRate * months;
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal ammount)
        {
            if (Balance - ammount < 0)
            {
                throw new InvalidOperationException("Not enough money in the account!");
            }
            Balance -= ammount;
        }

        public override string ToString()
        {
            return String.Format("Desposit account\n Holder {0}, Balance {1}, Interest Rate {2}", Holder, Balance, InterestRate);
        }
    }
}
