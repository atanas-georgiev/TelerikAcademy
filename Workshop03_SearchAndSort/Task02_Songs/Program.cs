﻿namespace Task02_Songs
{
    using System;
    using System.Linq;

    public class Startup
    {
        static long CountInversions(int[] array, int left, int right)
        {
            if (left + 1 == right)
            {
                return 0;
            }

            int middle = (left + right) / 2;

            long inversions = CountInversions(array, left, middle) + CountInversions(array, middle, right);

            int[] sorted = new int[right - left];
            int i = left;
            int j = middle;
            int k = 0;

            while (i < middle && j < right)
            {
                if (array[i] < array[j])
                {
                    sorted[k] = array[i];
                    i++;
                }
                else
                {
                    inversions += middle - i;
                    sorted[k] = array[j];
                    j++;
                }
                k++;
            }

            while (i < middle)
            {
                sorted[k] = array[i];
                i++;
                k++;
            }

            while (j < right)
            {
                sorted[k] = array[j];
                j++;
                k++;
            }

            for (k = 0; k < sorted.Length; k++)
            {
                array[left + k] = sorted[k];
            }

            return inversions;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rename = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                rename[array1[i]] = i;
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = rename[array2[i]];
            }

            var index1 = new int[n + 1];
            var index2 = new int[n + 1];

            Console.WriteLine(CountInversions(array2, 0, n));
        }

    }
}
