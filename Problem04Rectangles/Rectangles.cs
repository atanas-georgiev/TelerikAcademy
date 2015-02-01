//Problem 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

namespace Problem04Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Single width, height;

            try
            {
                Console.Write("Enter width:");
                width = Single.Parse(Console.ReadLine());

                Console.Write("Enter height:");
                height = Single.Parse(Console.ReadLine());

                Console.WriteLine("Perimeter = {0}", 2 * (width + height));
                Console.WriteLine("Area = {0}", width * height);
            }
            catch (FormatException)
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
