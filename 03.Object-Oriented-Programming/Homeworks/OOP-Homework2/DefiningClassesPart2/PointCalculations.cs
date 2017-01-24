using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 3. Static class
    /// Write a static class with a static method to calculate the distance between two points in the 3D space.
    /// </summary>
    static class PointCalculations
    {
        static Point3d PointDistance (Point3d point1, Point3d point2)
        {
            return new Point3d(point1.X - point2.X, point1.Y - point2.Y, point1.Z - point2.Z);
        }
    }
}
