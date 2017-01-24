using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement the ADT stack as auto - resizable array.
            //Resize the capacity on demand(when no space is available to add / insert a new element).

            Console.WriteLine("Create ADT stack with size 2");
            var myStack = new AdtStack<int>(2);

            Console.WriteLine("Add 1, 2, 3");
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("ADT stack size now is {0}", myStack.Size);

            Console.WriteLine("Stack elements: ");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}
