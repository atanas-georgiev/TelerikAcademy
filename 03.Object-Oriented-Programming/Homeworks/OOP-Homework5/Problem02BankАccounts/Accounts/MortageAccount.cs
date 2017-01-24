using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02BankАccounts.Customers;

namespace Problem02BankАccounts.Accounts
{
    class MortageAccount : Account, IDepositable
    {
        public MortageAccount(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (Holder is CompanyCustomer && months < 13)            
            {
                return InterestRate * months / 2;
            }

            if (Holder is IndividualCustomer && months < 7)
            {
                return 0;
            }

            return InterestRate * months;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return String.Format("Desposit account\n Holder {0}, Balance {1}, Interest Rate {2}", Holder, Balance, InterestRate);
        }
    }
}
