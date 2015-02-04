using System;

namespace Problem4
{
    class Problem4
    {
        static void Main()
        {
            int i, j;
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) Console.Write(":");
            Console.WriteLine();
            Console.Write(":");
            for (i = 0; i < n - 2; i++) Console.Write(" ");
            Console.Write("::");
            Console.WriteLine();
            Console.Write(":");
            for (i = 0; i < n - 2; i++) Console.Write(" ");
            Console.Write(":|:");
            Console.WriteLine();

            for (i = 0; i < n - 4; i++)
            {
                Console.Write(":");
                for (j = 0; j < n - 2; j++) Console.Write(" ");
                Console.Write(":");
                for (j = 0; j < 2 + i; j++) Console.Write("|");
                Console.Write(":");
                Console.WriteLine();
            }

            for (i = 0; i < n; i++) Console.Write(":");
            for (i = 0; i < n - 2; i++) Console.Write("|");
            Console.Write(":");
            Console.WriteLine();

            for (i = 1; i < n - 1; i++)
            {
                for (j = 0; j < i; j++) Console.Write(" ");
                Console.Write(":");
                for (j = 0; j < n - 2; j++) Console.Write("-");
                Console.Write(":");
                for (j = 0; (j < n - i - 2); j++) Console.Write("|");
                Console.Write(":");
                Console.WriteLine();
            }

            for (j = 0; j < n - 1; j++) Console.Write(" ");
            for (i = 0; i < n; i++) Console.Write(":");
        }
    }
}
