//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;

namespace Problem05MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            // Enter array lengths
            Console.WriteLine("Enter length of array: ");
            int len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            // Enter values for array
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter {0} value: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSeq = 1;
            int maxLen = 1;
            int maxPos = 1;

            // Search for maximal increasing sequence 
            for (int i = 0; i < len - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    maxSeq++;
                }
                else
                {
                    maxSeq = 1;
                }

                if (maxSeq > maxLen)
                {
                    maxLen = maxSeq;
                    maxPos = i - maxLen + 2;
                }
            }

            // Result
            Console.WriteLine("{0} maximum increasing values starting at index {1}: ", maxLen, maxPos);

            for (int i = maxPos; i < maxLen + maxPos; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}