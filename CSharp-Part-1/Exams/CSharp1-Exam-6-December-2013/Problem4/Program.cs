using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i, j;

            for (i = 0; i < n / 2 + 1; i++) Console.Write(".");
            for (i = 0; i < n; i++) Console.Write("*");
            for (i = 0; i < n / 2 + 1; i++) Console.Write(".");
            Console.WriteLine();

            for (i = 0; i < n / 2; i++)
            {
                for (j = 0; j < (n / 2) - i; j++) Console.Write(".");
                Console.Write("*");
                for (j = 0; j < i + n / 2; j++) Console.Write(".");
                Console.Write("*");
                for (j = 0; j < i + n / 2; j++) Console.Write(".");
                Console.Write("*");
                for (j = 0; j < (n / 2) - i; j++) Console.Write(".");
                Console.WriteLine();
            }

            for (i = 0; i < n * 2 + 1; i++) Console.Write("*");
            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i + 1; j++) Console.Write(".");
                Console.Write("*");
                for (j = 0; j < (n - 2) - i; j++) Console.Write(".");
                if (i != n - 1) Console.Write("*");
                for (j = 0; j < (n - 2) - i; j++) Console.Write(".");
                if (i != n - 1) Console.Write("*");
                for (j = 0; j < i + 1; j++) Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
