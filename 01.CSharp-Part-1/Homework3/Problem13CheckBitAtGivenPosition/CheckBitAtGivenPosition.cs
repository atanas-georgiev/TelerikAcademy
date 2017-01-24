//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position  p  (counting from  0 , starting from the right) in given integer number  n , has value of 1.

using System;

namespace Problem13CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            UInt32 data;
            Byte index;

            try
            {
                Console.Write("Enter integer number: ");
                data = UInt32.Parse(Console.ReadLine());
                Console.Write("Enter index: ");
                index = Byte.Parse(Console.ReadLine());

                if (index > 31)
                {
                    Console.WriteLine("Index is not correct");
                }
                else
                {
                    Console.WriteLine("Bit number {0} is {1}", index, Convert.ToBoolean(((data >> index) & 1)));
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