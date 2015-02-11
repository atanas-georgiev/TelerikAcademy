//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace Problem02EnterNumbers
{
    class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter number: ");
            int value = int.Parse(Console.ReadLine());
            
            if ((value < start) || (value > end))
            {
                throw new Exception("Invalid range entered");
            }

            return value;
        }
        static void Main()
        {
            int[] values = new int[10];
            int min = 1;
            int max = 100;

            try
            {
                values[0] = ReadNumber(min, max);
                for (int i = 1; i < values.Length; i++)
                {
                    min = values[i - 1];
                    values[i] = ReadNumber(min, max);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
