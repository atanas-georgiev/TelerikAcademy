// Problem 16.* Print Long Sequence
// Write a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, …  

using System;

namespace Problem16PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            const int FirstElement = 2;
            const int ElementsCount = 1000;

            int counter;

            for (counter = FirstElement; counter < FirstElement + ElementsCount; counter++)
            {
                if ((counter % 2) == 0)
                {
                    // Even number
                    Console.Write(counter);
                }
                else
                {
                    // Odd number
                    Console.Write(counter * (-1));
                }

                if (counter != FirstElement + ElementsCount - 1)
                {
                    // Do not display comma after last element
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
