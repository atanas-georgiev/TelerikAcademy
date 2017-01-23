//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;

namespace Problem15ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            input = input.Replace("<a href=\"", "[URL=");
            input = input.Replace("\">", "]");
            input = input.Replace("</a>", "[/URL]");

            Console.WriteLine(input);
        }
    }
}
