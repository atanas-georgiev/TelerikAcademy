//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;
using System.Linq;

namespace Problem02ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            Console.WriteLine(new string(str.ToCharArray().Reverse().ToArray()));
        }
    }
}
