using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02BankАccounts.Customers;
using Problem02BankАccounts.Accounts;

namespace Problem02BankАccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            DepositAccount account;

            // Deposit Ivan Ivanov
            account = new DepositAccount(new IndividualCustomer("Ivan", "Ivanov"), 0m, 3.1m);
            Console.WriteLine(account);
            Console.WriteLine("Interest rate for 3 months is " + account.CalculateInterest(3));
            Console.WriteLine("Deposit 1000");
            account.Deposit(1000);
            System.Console.WriteLine(account);
            Console.WriteLine("Interest rate for 3 months is " + account.CalculateInterest(3));

            // Deposit company Apple
            account = new DepositAccount(new CompanyCustomer("Apple"), 0m, 1m);
            Console.WriteLine(account);
            Console.WriteLine("Interest rate for 3 months is " + account.CalculateInterest(3));
            Console.WriteLine("Deposit 1000000");
            account.Deposit(1000000);
            System.Console.WriteLine(account);
            Console.WriteLine("Interest rate for 3 months is " + account.CalculateInterest(3));

            LoanAccount account1;
            // Loan Microsoft
            account1 = new LoanAccount(new CompanyCustomer("Microsoft"), 1000000m, 3m);
            Console.WriteLine(account1);
            Console.WriteLine("Interest rate for 3 months is " + account1.CalculateInterest(3));
            Console.WriteLine("Deposit 1000");
            account1.Deposit(1000);
            System.Console.WriteLine(account1);
            Console.WriteLine("Interest rate for 3 months is " + account1.CalculateInterest(3));

            MortageAccount account2;
            // Loan Atanas Georgiev
            account2 = new MortageAccount(new IndividualCustomer("Atanas", "Georgiev"), 10000m, 5.1m);
            Console.WriteLine(account2);
            Console.WriteLine("Interest rate for 3 months is " + account2.CalculateInterest(3));
            Console.WriteLine("Deposit 1000");
            account2.Deposit(1000);
            System.Console.WriteLine(account2);
            Console.WriteLine("Interest rate for 13 months is " + account2.CalculateInterest(13));
        }
    }
}


