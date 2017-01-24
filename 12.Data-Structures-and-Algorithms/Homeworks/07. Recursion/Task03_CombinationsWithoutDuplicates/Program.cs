// Write a recursive program for generating and printing all the combinations without duplicates of k elements from n-element set

namespace Task03_CombinationsWithoutDuplicates
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("n = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("k = ");
            var k = int.Parse(Console.ReadLine());

            CombinationWithoutDuplicates(1, n, new int[k], 0);
        }

        private static void CombinationWithoutDuplicates(int start, int end, int[] array, int index)
        {
            if (index >= array.Length)
            {
                PrintValues(array);
                return;
            }

            for (var i = start; i <= end; i++)
            {
                array[index] = i;
                CombinationWithoutDuplicates(start + i, end, array, index + 1);
            }
        }

        private static void PrintValues(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
