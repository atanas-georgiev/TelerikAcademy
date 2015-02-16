//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;

namespace Problem10UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.Write("\\u{0:X4}", (int)ch);
            }
        }
    }
}
