//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;

namespace Problem09FrequentNumber
{
    class FrequentNumber
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

            int mostFreq = 0;
            int curFreq = 0;
            int mostFreqNumber = array[0];
            int curNumber = array[0];

            // Search for most frequent number
            for (int i = 0; i < len; i++)
            {
                curFreq = 1;
                curNumber = array[i];

                for (int j = i + 1; j < len; j++)
                {
                    if (array[j] == curNumber)
                    {
                        curFreq++;
                    }
                }

                if (curFreq >= mostFreq)
                {
                    mostFreq = curFreq;
                    mostFreqNumber = curNumber;
                }
            }

            // Result
            Console.WriteLine("result: {0} ({1} times)", mostFreqNumber, mostFreq);
        }
    }
}
