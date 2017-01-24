//Problem 5. The Biggest of 3 Numbers
//• Write a program that finds the biggest of three numbers.

using System;

namespace Problem05TheBiggestOfThreeNumbers
{
    class BiggestOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c))
            {
                Console.WriteLine("Biggest: " + a);
            }
            else if ((b >= a) && (b >= c))
            {
                Console.WriteLine("Biggest: " + b);
            }
            else
            {
                Console.WriteLine("Biggest: " + c);
            }

        }
    }
}
