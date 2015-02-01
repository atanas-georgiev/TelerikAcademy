//Problem 13.* Comparing Floats
// Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 .

//Note: Two floating-point numbers  a  and  b  cannot be compared directly by  a == b  
// because of the nature of the floating-point arithmetic. Therefore, we assume two numbers 
// are equal if they are more closely to each other than a fixed constant  eps .


using System;

namespace Problem13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double precision = 0.000001d;
            double val1, val2, diff;

            Console.WriteLine("Enter first double value:");
            val1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second double value:");
            val2 = Double.Parse(Console.ReadLine());

            diff = (val1 > val2) ? (val1 - val2) : (val2 - val1);

            Console.WriteLine((precision > diff) ? "True" : "False");

        }
    }
}
