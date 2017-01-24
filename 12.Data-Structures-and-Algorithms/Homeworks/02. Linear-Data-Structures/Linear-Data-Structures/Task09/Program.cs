﻿namespace Task09
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private const int MaxNumber = 50;
        static void Main(string[] args)
        {
            //We are given the following sequence:

            //S1 = N;
            //S2 = S1 + 1;
            //S3 = 2 * S1 + 1;
            //S4 = S1 + 2;
            //S5 = S2 + 1;
            //S6 = 2 * S2 + 1;
            //S7 = S2 + 2;
            //...
            //Using the Queue < T > class write a program to print its first 50 members for given N.
            //Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();

            queue.Enqueue(n);
            var counter = 1;
            var result = new List<int>();

            while (counter < MaxNumber)
            {
                queue.Enqueue(queue.Peek() + 1);
                queue.Enqueue((2 * queue.Peek()) + 1);
                queue.Enqueue(queue.Peek() + 2);
                result.Add(queue.Dequeue());
                counter += 3;
            }

            while (queue.Count != 0)
            {
                result.Add(queue.Dequeue());
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
