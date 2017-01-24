//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Linq;

namespace Problem23SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            input.Distinct().Select(c => c.ToString()).ToList()
                .ForEach(c =>
                    {
                        while (input.Contains(c + c))
                            input = input.Replace(c + c, c);
                    }
                );

            Console.WriteLine(input);

        }
    }
}
