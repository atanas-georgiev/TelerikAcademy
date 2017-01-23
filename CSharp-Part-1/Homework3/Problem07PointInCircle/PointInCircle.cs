//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .

using System;

namespace Problem07PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Double x, y;

            try
            {
                Console.Write("x = ");
                x = double.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = double.Parse(Console.ReadLine());
                
                bool isInside = (x * x) + (y * y) <= (2 * 2);

                if (isInside == true)
                {
                    Console.WriteLine("Coordinates are inside the circle"); 
                }
                else
                {
                    Console.WriteLine("Coordinates are not inside the circle"); 
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
