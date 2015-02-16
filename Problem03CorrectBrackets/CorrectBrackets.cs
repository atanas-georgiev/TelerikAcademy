//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;

namespace Problem03CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter formula string: ");
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                try
                {
                    if (ch == '(')
                    {
                        stack.Push('.');
                    }
                    else if (ch == ')')
                    {
                        stack.Pop();
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Incorrect!");
                    return;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
