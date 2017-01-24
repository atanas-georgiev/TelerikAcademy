using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            int i, j;
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < (n - 1) / 2; i++)
            {
                for (j = 0; j < i; j++) Console.Write(".");
                Console.Write("\\");
                for (j = (n - 1) / 2 - 1 - i; j > 0; j--) Console.Write(".");
                Console.Write("|");
                for (j = (n - 1) / 2 - 1 - i; j > 0; j--) Console.Write(".");
                Console.Write("/");
                for (j = 0; j < i; j++) Console.Write(".");
                Console.WriteLine();
            }

            for (i = 0; i < (n - 1) / 2; i++) Console.Write("-");
            Console.Write("*");
            for (i = 0; i < (n - 1) / 2; i++) Console.Write("-");
            Console.WriteLine();

            for (i = 0; i < (n - 1) / 2; i++)
            {
                for (j = (n - 1) / 2 - 1 - i; j > 0; j--) Console.Write(".");
                Console.Write("/");
                for (j = 0; j < i; j++) Console.Write(".");
                Console.Write("|");
                for (j = 0; j < i; j++) Console.Write(".");
                Console.Write("\\");
                for (j = (n - 1) / 2 - 1 - i; j > 0; j--) Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
