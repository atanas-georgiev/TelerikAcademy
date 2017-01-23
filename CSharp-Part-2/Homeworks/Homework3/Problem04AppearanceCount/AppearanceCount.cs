//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

namespace Problem04AppearanceCount
{
    class AppearanceCount
    {
        static int CountNumberOccurance(int[] array, int digit)
        {
            int count = 0;

            foreach (var a in array)
            {
                if (a == digit)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main()
        {
            int[] arr = { 1, 3, 5, 2, 5, 6, 3, 1, 1, 2, 3, 4, 5, 6, 6, 7, 3, 2, 1, 3, 4, 5, 6, 74, 3, 2, 1, 2, 4 };
            Console.WriteLine("Digit 1 occure {0} times in the array", CountNumberOccurance(arr, 1));
        }
    }
}
