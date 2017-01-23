//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

namespace Problem06StringLength
{
    class StringLength
    {
        const int MAX_LEN = 20;
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            if (input.Length > MAX_LEN)
            {
                input = input.Substring(0, MAX_LEN);
            }
            else
            {
                input = input.PadRight(20, '*');
            }

            Console.WriteLine("Output: " + input);
        }
    }
}
