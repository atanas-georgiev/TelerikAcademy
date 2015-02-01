//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the double point.

using System;

namespace Problem05Calculations
{
    class Calculations
    {
        static void Main()
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);
            }

            Console.WriteLine("Sum = {0:0.00000}", sum);
        }
    }
}
