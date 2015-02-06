//Problem 20. Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;

namespace Problem20VariationsOfSet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("K: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                if ((i % n) == 0) Console.WriteLine();
                Console.Write(i / n + 1);
                Console.Write (i % n + 1);
            }
        }
    }
}
