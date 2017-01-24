using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 4. Path
    /// Create a class Path to hold a sequence of points in the 3D space.
    /// Create a static class PathStorage with static methods to save and load paths from a text file.
    /// Use a file format of your choice.
    /// </summary>
    class Path
    {
        private List<Point3d> points = new List<Point3d>();
        public Path() { }

        public void Add(Point3d point)
        {
            points.Add(point);
        }
        public void Remove(Point3d point)
        {
            points.Remove(point);
        }
        public void Clear()
        {
            points.Clear();
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            foreach (Point3d point in points)
            {
                res.Append(string.Format("Point3d: {0} {1} {2}\n", point.X, point.Y, point.Z));
            }
            return res.ToString();
        }

        public void StoreInFile(string fileName)
        {
            StreamWriter writer;

            using (writer = new StreamWriter(fileName, false))
            {
                foreach (Point3d point in points)
                {
                    writer.WriteLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            StreamReader reader;

            using (reader = new StreamReader(fileName, false))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] values = line.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                    points.Add(new Point3d(values[0], values[1], values[2]));
                    line = reader.ReadLine();
                }
            }
        }

    }
}
