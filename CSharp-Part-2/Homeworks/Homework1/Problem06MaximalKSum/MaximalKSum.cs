//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

namespace Problem06MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            // Enter array lengths
            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            // Enter values for array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} value: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxSum = 0;
            int index = 0;

            // Search for maximal sum sequence 
            for (int i = index; i < n; i++)
            {
                for (int j = i; ((j < (k + i)) && (j < n)); j++)
                {
                    sum += array[j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }

                sum = 0;
            }

            // Result
            Console.WriteLine("Maximum sum is {0}: ", maxSum);
        }
    }
}
