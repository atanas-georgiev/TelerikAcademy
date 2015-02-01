//Problem 9. Trapezoids
// Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .


using System;

namespace Problem09Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Single a, b, height;

            try
            {
                Console.Write("Enter A:");
                a = Single.Parse(Console.ReadLine());

                Console.Write("Enter B:");
                b = Single.Parse(Console.ReadLine());

                Console.Write("Enter height:");
                height = Single.Parse(Console.ReadLine());

                Console.WriteLine("Perimeter = {0}", ((a + b) / 2) * height);
            }
            catch (FormatException)
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
