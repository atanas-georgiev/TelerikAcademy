namespace Task01_BinaryTrees
{
    using System;
    using System.Numerics;

    public class Program
    {
        private static int[] numbers;
        private static BigInteger[] factorials;

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var len = input.Length;

            numbers = new int[26];
            factorials = new BigInteger[len * 2 + 1];

            foreach (var value in input)
            {
                numbers[value - 'A'] += 1;
            }

            factorials[0] = 1;

            for (var i = 0; i < len * 2; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            BigInteger result = factorials[2 * len] / factorials[len + 1];

            foreach (var value in numbers)
            {
                result /= factorials[value];
            }

            Console.WriteLine(result);
        }
    }
}
