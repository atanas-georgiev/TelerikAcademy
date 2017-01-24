//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 = n = 20) and 
//prints a matrix like in the examples below. Use two nested loops.

using System;

namespace Problem09MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());

            if ((n >= 1) && (n <= 20))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0} ", i + j + 1);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter value between 1 and 20");
            }
        }
    }
}
