//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

namespace Problem06FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
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

            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (true == CheckIfLargerThanNeighbours(arr, i))
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
