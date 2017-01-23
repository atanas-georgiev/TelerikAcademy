//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;

namespace Problem03EnglishDigit
{
    class EnglishDigit
    {
        static string DisplayDigit(int digit)
        {
            switch (digit % 10)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Laster digit in english is " + DisplayDigit(x));
        }
    }
}
