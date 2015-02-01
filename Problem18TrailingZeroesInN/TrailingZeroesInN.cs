//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;

namespace Problem18TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int zeros = 0;
            int powFive = 1;
            int denominator = 0;

            while (denominator <= number)
            {
                denominator = (int)Math.Pow(5, powFive);
                zeros += number / denominator;
                ++powFive;
            }

            Console.WriteLine("{0}! has {1} trailing zeros.", number, zeros);
        }

    }
}
