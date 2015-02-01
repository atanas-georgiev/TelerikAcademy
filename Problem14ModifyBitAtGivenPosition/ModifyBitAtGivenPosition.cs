//Problem 14. Modify a Bit at Given Position
// We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
// Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  at the position  p  from the binary representation of  n  while preserving all other bits in  n .

using System;

namespace Problem14ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            UInt32 n;
            Byte v;
            Byte p;

            try
            {
                Console.Write("Enter integer number: ");
                n = UInt32.Parse(Console.ReadLine());
                Console.Write("Enter bit position: ");
                p = Byte.Parse(Console.ReadLine());
                Console.Write("Enter bit value: ");
                v = Byte.Parse(Console.ReadLine());

                if ((p > 31) || (v > 1))
                {
                    Console.WriteLine("Input data is not correct");
                }
                else
                {
                    if (v == 1)
                    {
                        UInt32 setOne = (UInt32)1 << p;
                        UInt32 foundBitOne = n | setOne;
                        Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
                        Console.WriteLine("Result: " + foundBitOne);
                    }
                    else
                    {
                        UInt32 setZero = ~((UInt32)1 << p);
                        UInt32 foundBitZero = n & setZero;
                        Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
                        Console.WriteLine("Result: " + foundBitZero);
                    }

                }
            }
            catch
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
