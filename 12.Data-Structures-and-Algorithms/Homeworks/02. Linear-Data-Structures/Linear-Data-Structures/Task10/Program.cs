namespace Task10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            //We are given numbers N and M and the following operations:

            //N = N + 1
            //N = N + 2
            //N = N * 2

            //Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.

            //Hint: use a queue.
            //Example: N = 5, M = 16
            //Sequence: 5 → 7 → 8 → 16

            int n = 5;
            int m = 120;

            var shortestSequance = ShortestSequance(n, m);
            Console.WriteLine(string.Join(", ", shortestSequance));
        }

        public static List<int> ShortestSequance(int start, int end)
        {
            Stack<int> sequance = new Stack<int>();
            int currentNumber = end;
            sequance.Push(currentNumber);

            while (currentNumber > start)
            {
                if (currentNumber % 2 == 0 && currentNumber / 2 >= start)
                {
                    currentNumber /= 2;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber % 2 == 1 && currentNumber / 2 >= start)
                {
                    currentNumber -= 1;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber - 2 >= start)
                {
                    currentNumber -= 2;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber - 1 >= start)
                {
                    currentNumber -= 1;
                    sequance.Push(currentNumber);
                }
            }

            return sequance.ToList();
        }
    }
}
