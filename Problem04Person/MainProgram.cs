using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04Person
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test problem 4
            Person person1 = new Person("Atanas");
            Console.WriteLine(person1);

            Person person2 = new Person("Ivan", 22);
            Console.WriteLine(person2);
        }
    }
}
