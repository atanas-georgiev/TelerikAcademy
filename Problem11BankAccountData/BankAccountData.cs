//Problem 11. Bank Account Data
// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

namespace Problem11BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName, surName, familyName;
            decimal balance;
            string bankName;
            string iban;
            ulong[] cards = new ulong[3];

            firstName = "Ivan";
            surName = "Georgiev";
            familyName = "Dimitrov";
            balance = 104546.23m;
            bankName = "DSK";
            iban = "BG80BNBG96611020345678";
            cards[0] = 12345678910;
            cards[1] = 12345678911;
            cards[2] = 12345678912;

            Console.WriteLine("Name: {0} {1} {2}", firstName, surName, familyName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank Name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            foreach (ulong i in cards)
            {
                Console.WriteLine("Card: {0}", i);
            }
        }
    }
}
