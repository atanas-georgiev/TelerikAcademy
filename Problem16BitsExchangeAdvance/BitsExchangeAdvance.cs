//Problem 16.** Bit Exchange (Advanced) 
// Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;

namespace Problem16BitsExchangeAdvance
{
    class BitsExchangeAdvance
    {
        static int SwapBits(int n, int first, int second)
        {
            n ^= (1 << first);
            return n ^ (1 << second);
        }

        static void Main()
        {
            long number;
            int firstPos, secondPos, size;

            Console.Write("Number =  ");
            number = long.Parse(Console.ReadLine());
            Console.Write("First position =  ");
            firstPos = Int32.Parse(Console.ReadLine());
            Console.Write("Second position =  ");
            secondPos = Int32.Parse(Console.ReadLine());
            Console.Write("Bits count =  ");
            size = Int32.Parse(Console.ReadLine());

            if (firstPos >= secondPos)
            {
                Console.WriteLine("First position greater or equal to second position");
            }
            else if (size > 31)
            {
                Console.WriteLine("Specified size is too large");
            }
            else if ((firstPos + size) >= secondPos)
            {
                Console.WriteLine("Overlapping");
            }
            else if ((secondPos + size) > 31)
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int p = firstPos, q = secondPos, k = size;
                    (p <= 32 && q <= 32) && k > 0;
                     p++, q++, k--)
                {

                    if (((number >> p) & 1) != ((number >> q) & 1))
                    {
                        number = BitsExchangeAdvance.SwapBits((int)number, p, q);
                    }

                }
                Console.WriteLine("Binary representation : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine("The result {0}", number);
            }
        }
    }
}
