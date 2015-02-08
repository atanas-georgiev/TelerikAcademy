//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

namespace Problem05LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static bool CheckIfLargerThanNeighbours(int[] array, int index)
        {
            if ((index <= 0) || (index >= array.Length - 1))
            {
                return false;
            }
            else if ((array[index] > array[index + 1]) && (array[index] > array[index - 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            int[] arr = { 1, 3, 5, 2, 5, 6, 3, 1, 1, 2, 3, 4, 5, 6, 6, 7, 3, 2, 1, 3, 4, 5, 6, 74, 3, 2, 1, 2, 4 };
            Console.WriteLine("Enter position: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Larger Than Neighbors: ", CheckIfLargerThanNeighbours(arr, x));

        }
    }
}
