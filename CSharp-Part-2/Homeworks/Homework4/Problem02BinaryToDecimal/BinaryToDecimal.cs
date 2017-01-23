//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

namespace Problem02BinaryToDecimal
{
    class BinaryToDecimal
    {
        static int BinaryToDecimalFunc(string number)
        {
            int result = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += (int)((number[i] - '0') * Math.Pow(2, number.Length - i - 1));
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter binary number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Binary representation of {0} bin is {1} dec.", number, BinaryToDecimalFunc(number));

        }
    }
}
