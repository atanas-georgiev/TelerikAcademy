//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem04SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter substring: ");
            string subStr = Console.ReadLine();

            Console.WriteLine("Substring {0} appears {1} times in the text. ", subStr, Regex.Matches(str, subStr).Cast<Match>().Count());
        }
    }
}
