//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;
using System.Collections.Generic;

namespace Problem10NFactorial
{
    class NFactorial
    {
        static int[] ArrayMultiply(int[] arr, int value)
        {
            BigInteger bi = new BigInteger();

            // Array to big integer
            for (int i = 0; i < arr.Length; i++)
            {
                bi += arr[i] * (BigInteger)Math.Pow(10, arr.Length - i - 1);
            }

            // Multiply
            bi *= value;

            List<int> l = new List<int>();

            // big integer to array
            while (bi != 0)
            {
                l.Add((int)(bi % 10));
                bi /= 10;
            }

            int[] res = l.ToArray();
            Array.Reverse(res);

            return res;
        }

        static void Main()
        {
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = { 1 };

            for (int i = 1; i < n + 1; i++)
            {
                // Calculate factorial
                arr = ArrayMultiply(arr, i);
            }

            //Display result
            Console.Write("N! = ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
