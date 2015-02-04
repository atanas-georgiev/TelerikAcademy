//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

namespace Problem10FindSumInArray
{
    class FindSumInArray
    {

        static void Main()
        {
            // Enter array length
            Console.WriteLine("Enter length of array: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("S: ");
            int s = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            // Enter values for array
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter Array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int minCurIndex = 0;
            int currentSum = 0;

            // Search for most frequent number
            for (int i = 0; i < len; i++)
            {
                currentSum = 0;
                minCurIndex = i;

                for (int j = i; j < len; j++)
                {
                    currentSum += array[j];

                    if (currentSum == s)
                    {
                        // Sum found
                        Console.WriteLine("Sum found: ");
                        for (int k = i; k < j + 1; k++) Console.Write(array[k] + ", ");
                        return;
                    }
                }
            }

            // Result
            Console.WriteLine("Sum not found in the array!");
        }
    }
}
