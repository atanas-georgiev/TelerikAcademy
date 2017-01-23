//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

namespace Problem08PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Byte number;

            Console.Write("Enter number: ");

            try
            {
                number = Byte.Parse(Console.ReadLine());

                if (number >= 100)
                {
                    Console.WriteLine("Number should not be more than 100");
                }
                else
                {
                    Byte k = 0;

                    for (Byte i = number; i > 1; i--)
                    {
                        if ((number % i) == 0)
                        {
                            k++;
                        }
                    }

                    if (k == 1)
                    {
                        Console.WriteLine("Number is prime");
                    }
                    else
                    {
                        Console.WriteLine("Number is not prime");
                    }
                }
            }
            catch
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
