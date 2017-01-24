//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

namespace Problem14DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            long num = long.Parse(Console.ReadLine());
            string result = "";

            while (num > 0)
            {
                result += (num % 2).ToString();
                num = num / 2;
            }

            // Reverse result
            result = Reverse(result);

            Console.WriteLine("Result: " + result);
        }
    }
}
