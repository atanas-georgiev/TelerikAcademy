//Problem 4. Multiplication Sign
//• Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. ◦ Use a sequence of  if  operators.

using System;

namespace Problem04MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            sbyte count = 0;
            string sign = "";

            if (a < 0)
            {
                count++;
            }

            if (b < 0)
            {
                count++;
            }

            if (c < 0)
            {
                count++;
            }

            if (count % 2 != 0)
            {
                sign = "-";
            }
            else
            {
                sign = "+";
            }

            if (a == 0 || b == 0 || c == 0)
            {
                sign = "0";
            }

            Console.WriteLine("Sign = " + sign);
        }
    }
}
