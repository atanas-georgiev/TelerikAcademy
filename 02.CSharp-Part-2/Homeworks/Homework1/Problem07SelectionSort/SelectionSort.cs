//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

namespace Problem07SelectionSort
{
    class SelectionSort
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            // Enter array length
            Console.WriteLine("length: ");
            int n = int.Parse(Console.ReadLine());

            // Create new array
            int[] array = new int[n];

            // Enter values for array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} value: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            // Selection sort
            int min;            
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(ref array[i], ref array[min]);
                }
            }

            // Display results
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Array[{0}] = {1}: ", i, array[i]);                
            }

        }
    }
}
