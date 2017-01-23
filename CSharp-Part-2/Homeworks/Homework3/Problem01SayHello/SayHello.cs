//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;

namespace Problem01SayHello
{
    class SayHello
    {
        static string DisplayHello(string name)
        {
            return "Hello, " + name + "!";
        }

        static void Main()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(DisplayHello(name));
        }
    }
}
