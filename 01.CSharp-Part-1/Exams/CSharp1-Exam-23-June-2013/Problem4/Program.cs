using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            int i, j;
            int n = int.Parse(Console.ReadLine());

            for (i = (n / 2); i > 0; i--)
            {
                for (j = (n / 2) - i; j < (n / 2) - 1; j++) Console.Write(".");
                Console.Write("#");
                for (j = i; j < (n / 2); j++) Console.Write(".");
                for (j = i; j < (n / 2); j++) Console.Write(".");
                Console.Write("#");
                for (j = (n / 2) - i; j < (n / 2) - 1; j++) Console.Write(".");
                Console.WriteLine();
            }

            for (i = 0; i < (n / 4); i++)
            {

                for (j = 0; j < i; j++) Console.Write(".");
                Console.Write("#");
                for (j = 0; j < (n / 2) - 1 - i; j++) Console.Write(".");
                for (j = 0; j < (n / 2) - 1 - i; j++) Console.Write(".");
                Console.Write("#");
                for (j = 0; j < i; j++) Console.Write(".");
                Console.WriteLine();
            }

            for (i = 0; i < n; i++) Console.Write("-");
            Console.WriteLine();

            for (i = 0; i < (n / 2); i++)
            {
                for (j = (n / 2) - i; j < (n / 2); j++) Console.Write(".");
                for (j = 0; j < (n / 2) - i; j++) Console.Write("\\");
                for (j = 0; j < (n / 2) - i; j++) Console.Write("/");
                for (j = (n / 2) - i; j < (n / 2); j++) Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
