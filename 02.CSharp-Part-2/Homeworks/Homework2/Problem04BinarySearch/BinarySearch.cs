//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

namespace Problem04BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("K= ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            // Sort array
            Array.Sort(array);

            while (Array.BinarySearch(array, k) < 0)
            {
                k--;
            }

            Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
        }
    }
}
