using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem05BitArray
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            BitArray64 value = new BitArray64("10001011100");
            Console.WriteLine("value = " + value);
            Console.WriteLine("Set bit 0 to 1");
            value[0] = true;
            Console.WriteLine("value = " + value);
            Console.WriteLine("Bit 0 is " + value[0]);
            Console.WriteLine("foreach display: ");
            foreach (var item in value)
            {
                Console.Write(item);
            }

            BitArray64 value2 = new BitArray64("10001011100");
            Console.WriteLine();
            Console.WriteLine("value2 = " + value);
            
            Console.WriteLine("value == value2: " + (value == value2));
            Console.WriteLine("value != value2: " + (value != value2));
            
        }
    }
}
