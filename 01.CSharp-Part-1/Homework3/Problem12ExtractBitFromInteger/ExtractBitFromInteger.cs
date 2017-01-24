//Problem 12. Extract Bit from Integer
// Write an expression that extracts from given integer  n  the value of given bit at index  p .

using System;

namespace Problem12ExtractBitFromInteger
{
    class ExtractBitFromInteger
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
                    Console.WriteLine("Bit number {0} is {1}", index, ((data >> index) & 1));
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
