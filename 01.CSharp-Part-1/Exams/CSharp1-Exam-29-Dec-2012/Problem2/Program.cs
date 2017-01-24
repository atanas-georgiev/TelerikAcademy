using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            long[] numbers = new long[x * y];
            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;
            numbers[3] = d;

            for (int i = 4; i < x * y; i++)
            {
                numbers[i] = numbers[i - 4] + numbers[i - 3] + numbers[i - 2] + numbers[i - 1];
            }

            int n = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0} ", numbers[n]);
                    n++;
                }
                Console.WriteLine();
            }

        }
    }
}
