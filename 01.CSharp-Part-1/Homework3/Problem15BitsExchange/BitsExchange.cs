//Problem 15.* Bits Exchange
//Write a program that exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer.

using System;

namespace Problem15BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            UInt32 n;

            try
            {
                Console.Write("Enter integer number: ");
                n = UInt32.Parse(Console.ReadLine());

                UInt32 mask1 = n & 0x38; // mask only bits 3,4,5
                UInt32 mask2 = n & 0x7000000; // mask only bits 24,25,26

                // swap bits
                mask1 <<= 21;
                mask2 >>= 21;

                n &= 0xF8FFFFC7; // clear bits 3,4,5,24,25,26
                n = n | mask1 | mask2; // Sum final result with swap bits

                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("Result: " + n);
            }
            catch
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
