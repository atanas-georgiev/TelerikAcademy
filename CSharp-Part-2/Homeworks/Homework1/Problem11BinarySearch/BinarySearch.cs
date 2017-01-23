//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

namespace Problem11BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            // Declare test array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 34, 56, 78, 98, 99 };

            // Enter search value
            Console.WriteLine("Enter value: ");
            int x = int.Parse(Console.ReadLine());

            int start = 0;
            int end = array.Length - 1;
            int mid = 0;

            // Binary search
            while (start <= end)
            {
                mid = (start + end) / 2;

                if (array[mid] < x)
                {
                    start = mid + 1;
                    continue;
                }

                if(array[mid]>x)
                {
                    end = mid - 1;
                    continue;
                }

                if (array[mid] == x)
                {
                    // Value found
                    Console.WriteLine("Index is: " + mid);
                    return;
                }
            }
            Console.WriteLine("Value not found!");
        }
    }
}
