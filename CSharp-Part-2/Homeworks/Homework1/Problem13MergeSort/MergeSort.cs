//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm (find it in Wikipedia).

using System;

namespace Problem13MergeSort
{
    class MergeSort
    {
        static void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, numElements, tmpPost;

            leftEnd = (mid - 1);
            tmpPost = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmpPost++] = numbers[left++];
                else
                    temp[tmpPost++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tmpPost++] = numbers[left++];

            while (mid <= right)
                temp[tmpPost++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
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
            MergeSort_Recursive(array, 0, len - 1);

            // Display array
            for (int i = 0; i < len; i++)
            {
                Console.Write("{0},  ", array[i]);
            }
        }
    }
}
