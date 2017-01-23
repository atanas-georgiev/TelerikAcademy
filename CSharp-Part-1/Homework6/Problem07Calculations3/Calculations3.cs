//Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;

namespace Problem07Calculations3
{
    class Calculations3
    {
        static void Main()
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("k = ");
            double k = double.Parse(Console.ReadLine());
            double m = n - k;
            double factorialN = 1;
            double factorialK = 1;
            double factorialM = 1;

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

                while (true)
                {
                    if (m <= 1)
                    {
                        break;
                    }
                    factorialM *= m;
                    m--;
                }

                Console.WriteLine("n! / (k! * (n-k)!) = " + factorialN / (factorialK * factorialM));
            }
            else
            {
                Console.WriteLine("Please enter values in range (1 < k < n < 100)");
            }
        }
    }
}
