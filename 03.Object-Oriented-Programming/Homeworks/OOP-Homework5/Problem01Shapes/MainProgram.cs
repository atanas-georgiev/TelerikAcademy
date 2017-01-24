//Problem 1. Shapes

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Rectangle(3,4),
                new Rectangle(23,12.5),
                new Triangle(12,15.4),
                new Triangle(1,5),
                new Circle(32.1),
                new Circle(12.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine("Surface: {0}", shape.CalculateSurface());
            }
        }
    }
}
