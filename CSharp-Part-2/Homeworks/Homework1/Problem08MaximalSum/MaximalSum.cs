//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

using System;

namespace Problem08MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            // Enter array length
            Console.WriteLine("Enter length of array: ");
            int len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            // Enter values for array
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter Array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int minIndex = 0;
            int maxIndex = 0;
            int maxSum = 0;
            int currentSum = 0;

            // Search for maximal sum 
            for (int i = 0; i < len; i++)
            {
                currentSum = 0;

                for (int j = i; j < len; j++)
                {
                    currentSum += array[j];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        minIndex = i;
                        maxIndex = j;
                    }
                }
            }

            // Result
            Console.WriteLine("Sum = {0}", maxSum);

            for (int i = minIndex; i < maxIndex + 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
