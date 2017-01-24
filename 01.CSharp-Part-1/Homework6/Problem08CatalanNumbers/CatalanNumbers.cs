//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;

namespace Problem08CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            double nPlus1 = n + 1;
            double n2 = n * 2;
            double factorialN = 1;
            double factorial2N = 1;
            double factorialNplus1 = 1;

            if (n >= 0)
            {
                while (true)
                {
                    if (n <= 1)
                    {
                        break;
                    }
                    factorialN *= n;
                    n--;
                }

                while (true)
                {
                    if (n2 <= 1)
                    {
                        break;
                    }
                    factorial2N *= n2;
                    n2--;
                }

                while (true)
                {
                    if (nPlus1 <= 1)
                    {
                        break;
                    }
                    factorialNplus1 *= nPlus1;
                    nPlus1--;
                }

                Console.WriteLine("Catalan = {0}", factorial2N / (factorialNplus1 * factorialN));
            }
            else
            {
                Console.WriteLine("Please enter value >= 0");
            }
        }
    }
}
