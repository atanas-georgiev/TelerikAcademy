namespace Task01_PriorityQueue
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var queue = new PriorityQueue<int>(new MyComperer());
            queue.Push(5);
            queue.Push(1);
            queue.Push(2);
            queue.Push(8);

            while (queue.Size > 0)
            {
                Console.WriteLine(queue.Pop());
            }
        }
    }
}
