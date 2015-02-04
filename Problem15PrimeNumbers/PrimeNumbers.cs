//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

namespace Problem15PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            long sum = 0;
            long n = 10000000;

            // Define new array
            bool[] array = new bool[n];

            for (int i = 2; i < n; i++)
            {
                //set all numbers to true
                array[i] = true;
            }

            // Sieve of Eratosthenes algorithm
            for (int i = 2; i < n; i++)
            {
                if (array[i])
                {
                    for (long p = 2; (p * i) < n; p++)
                    {
                        array[p * i] = false;
                    }
                }
            }

            // Do not run, too long time !!!
            for (int i = 2; i < n; i++)
            {
                if (array[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
