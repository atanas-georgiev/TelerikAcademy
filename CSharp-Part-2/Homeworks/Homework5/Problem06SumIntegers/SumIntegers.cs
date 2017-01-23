//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

namespace Problem06SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter integer values, separated by space: ");
            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');
            double sum = 0;

            foreach (string number in numbers)
            {
                sum += double.Parse(number);
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
