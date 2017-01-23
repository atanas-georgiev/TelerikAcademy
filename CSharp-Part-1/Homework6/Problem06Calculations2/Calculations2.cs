//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

namespace Problem06Calculations2
{
    class Calculations2
    {
        static void Main()
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("k = ");
            double k = double.Parse(Console.ReadLine());
            double factorialN = 1;
            double factorialK = 1;

            if ((1 < k) && (k < n) && (n < 100))
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
                    if (k <= 1)
                    {
                        break;
                    }
                    factorialK *= k;
                    k--;
                }

                Console.WriteLine("n! / k! = " + factorialN / factorialK);
            }
            else
            {
                Console.WriteLine("Please enter values in range (1 < k < n < 100)");
            }
        }
    }
}
