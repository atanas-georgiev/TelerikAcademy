// Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).

namespace Task05_OrderedSubsets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var k = 2;
            var set = new[] { "hi", "a", "b" };

            CombinationWithoutDuplicates(set, 0, new string[k]);
        }

        private static void CombinationWithoutDuplicates(string[] array, int index, string[] res)
        {
            if (index >= res.Length)
            {
                PrintValues(res);
                return;
            }

            for (var i = 0; i < array.Length; i++)
            {
                res[index] = array[i];                
                CombinationWithoutDuplicates(array, index + 1, res);
            }
        }

        private static void PrintValues(string[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
