// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

namespace Task01_NestedLoopsSimulation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("N = ");
            var n = int.Parse(Console.ReadLine());
            SimulateLoops(1, new int[n]);
        }

        private static void SimulateLoops(int index, int[] array)
        {
            if (index > array.Length)
            {
                PrintValues(array);
                return;
            }

            for (var i = 1; i <= array.Length; i++)
            {
                array[index - 1] = i;
                SimulateLoops(index + 1, array);
            }
        }

        private static void PrintValues(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
