//Problem 12. Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable. 
// Try to print these variables at the console. 
// Try to add some number or the null literal to these variables and print the result.

using System;

namespace Problem12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullableIntValue = null;
            Nullable<double> nullableDaubleValue = null;

            Console.WriteLine("Assign null to both variables");
            Console.WriteLine("nullableIntValue = " + nullableIntValue);
            Console.WriteLine("nullableDaubleValue = " + nullableDaubleValue);

            nullableIntValue = 1;
            nullableDaubleValue = 2;

            Console.WriteLine("Assign some value to both variables");
            Console.WriteLine("nullableIntValue = " + nullableIntValue);
            Console.WriteLine("nullableDaubleValue = " + nullableDaubleValue);

            nullableIntValue = null;
            nullableDaubleValue = null;

            Console.WriteLine("Assign null to both variables");
            Console.WriteLine("nullableIntValue = " + nullableIntValue);
            Console.WriteLine("nullableDaubleValue = " + nullableDaubleValue);
        }
    }
}
