using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 1. Structure
    /// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    /// Implement the ToString() to enable printing a 3D point.
    /// </summary>
    struct Point3d
    {
        /// <summary>
        /// Problem 2. Static read-only field
        /// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        /// Add a static property to return the point O.
        /// </summary>
        private static readonly Point3d o = new Point3d(0, 0, 0);
        private int x, y, z;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }

        public static Point3d O
        {
            get { return o; }
        }

        public Point3d(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            return String.Format("Point with coordinates {0} {1} {2}", X, Y, Z);
        }
    }
}
