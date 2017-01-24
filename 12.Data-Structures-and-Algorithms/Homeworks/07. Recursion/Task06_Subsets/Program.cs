// Write a program for generating and printing all subsets of k strings from given set of strings.
// s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)

namespace Task06_Subsets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var k = 2;
            var set = new[] { "test", "rock", "fun" };

            GenerateSubset(new string[k], set, 0);
        }

        private static void GenerateSubset(string[] array, string[] set, int index)
        {
            if (index >= array.Length)
            {
                PrintValues(array);
                return;
            }

            for (var i = index; i <= array.Length; i++)
            {
                array[index] = set[i];
                GenerateSubset(array, set, index + 1);
            }
        }

        private static void PrintValues(string[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
