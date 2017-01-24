// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

namespace Problem01OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Int32 number;

            Console.WriteLine("Enter integer number:");

            try
            {
                number = Int32.Parse(Console.ReadLine());

                // Check if number is even
                if ((number % 2) == 0)
                {
                    Console.WriteLine("Number is even.");
                }
                else
                {
                    Console.WriteLine("Number is odd.");
                }
            }
            catch (FormatException)
            {
                // Invalid number is entered. Handle exception
                Console.WriteLine("Entered number is not correct");
            }
        }
    }
}
