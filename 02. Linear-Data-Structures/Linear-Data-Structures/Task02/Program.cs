using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads N integers from the console and reverses them using a stack.
            // Use the Stack<int> class.

            var numbersStack = new Stack<int>();

            Console.WriteLine("Enter N: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number: ");
                numbersStack.Push(int.Parse(Console.ReadLine()));
            }

            while (numbersStack.Count != 0)
            {
                Console.WriteLine(numbersStack.Pop());
            }
        }
    }
}
