//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm (find it in Wikipedia).

using System;

namespace Problem14QuickSort
{
    class QuickSort
    {
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For recursion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }

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

            // Sort
            QuickSort_Recursive(array, 0, len - 1);

            // Display array
            for (int i = 0; i < len; i++)
            {
                Console.Write("{0},  ", array[i]);
            }
        }
    }
}
