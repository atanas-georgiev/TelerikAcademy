//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

namespace Problem12RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int temp;

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                do
                {
                    temp = rnd.Next(1, n + 1);
                }
                while (list.Contains(temp));

                list.Add(temp);
            }

            foreach (int i in list)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}
