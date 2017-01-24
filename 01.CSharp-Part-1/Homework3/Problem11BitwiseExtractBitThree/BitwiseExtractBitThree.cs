//Problem 11. Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
// The bits are counted from right to left, starting from bit  #0 .
// The result of the expression should be either  1  or  0 .

using System;

namespace Problem11BitwiseExtractBitThree
{
    class BitwiseExtractBitThree
    {
        static void Main()
        {
            UInt32 data;

            try
            {
                Console.Write("Enter integer number: ");
                data = UInt32.Parse(Console.ReadLine());

                Console.WriteLine("Third bit is {0}", ((data >> 3) & 1));
            }
            catch
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}