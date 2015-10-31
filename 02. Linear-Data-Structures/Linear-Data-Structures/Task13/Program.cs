using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement the ADT queue as dynamic linked list.
            //Use generics (LinkedQueue<T>)to allow storing different data types in the queue.

            LinkedQueue<int> queue = new LinkedQueue<int>();

            Console.WriteLine("Add 1,2,3 in the queue");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Dequeue the values");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
