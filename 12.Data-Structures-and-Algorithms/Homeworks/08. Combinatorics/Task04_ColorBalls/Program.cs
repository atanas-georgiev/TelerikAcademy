namespace Task04_ColorBalls
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        private static BigInteger[] factorials;

        private const int MaxNumber = 30;

        private static int[] numbers;

        public static void Main(string[] args)
        {
            factorials = new BigInteger[MaxNumber + 1];

            factorials[0] = 1;

            for (var i = 0; i < MaxNumber; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            var input = Console.ReadLine();
            var len = input.Length;

            numbers = new int[26];

            foreach (var value in input)
            {
                numbers[value - 'A'] += 1;
            }

            BigInteger result = factorials[len];

            result = numbers.Where(x => x != 0).Aggregate(result, (current, value) => current / factorials[value]);

            Console.WriteLine(result);
        }
    }
}
