﻿namespace Task05
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that removes from given sequence all negative numbers.

            var numbersList = new List<int>();

            do
            {
                Console.WriteLine("Enter number: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    // exit
                    break;
                }

                numbersList.Add(int.Parse(input));
            }
            while (true);

            numbersList.RemoveAll(x => x < 0);
            numbersList.ForEach(Console.WriteLine);
        }
    }
}
