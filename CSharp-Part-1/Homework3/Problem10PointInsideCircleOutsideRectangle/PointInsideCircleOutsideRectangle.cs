//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .

using System;

namespace Problem10PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Double x1 = 1;
            Double y1 = 1;

            try
            {
                Console.Write("Enter value for x1: ");
                x1 = double.Parse(Console.ReadLine());
                Console.Write("Enter value for y1: ");
                y1 = double.Parse(Console.ReadLine());

                bool insideCircle = (x1 - 1) * (x1 - 1) + (y1 - 1) * (y1 - 1) <= (1.5 * 1.5);
                bool insideRectangle = x1 > 1 || x1 < 6 && y1 > -1 || y1 < 2;

                if ((insideCircle == true) && (insideRectangle != true))
                {
                    Console.WriteLine("Inside a circle  K({1, 1}, 1.5)");
                }
                else
                {
                    Console.WriteLine("Not inside a circle  K({1, 1}, 1.5)");
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
