//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

namespace Problem13BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string str = Console.ReadLine();
            long result = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += long.Parse(str[str.Length - i - 1].ToString()) * (long)Math.Pow(2, i);
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
