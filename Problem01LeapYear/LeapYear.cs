//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

namespace Problem01LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is year leap? {0}", DateTime.IsLeapYear(year));
        }
    }
}
