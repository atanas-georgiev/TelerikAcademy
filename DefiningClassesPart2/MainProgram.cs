using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DefiningClassesPart2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test Problems 01 - 04
            Console.WriteLine("Class point3d");
            Console.WriteLine("------------------------------------------------");
            Path points = new Path();
            points.Add(new Point3d(Point3d.O.X, Point3d.O.Y, Point3d.O.Z));
            points.Add(new Point3d(1, 1, 1));
            points.Add(new Point3d(2, 2, 2));
            points.Add(new Point3d(3, 3, 3));

            Console.WriteLine("Points in the object");
            Console.WriteLine(points);

            try
            {
                Console.WriteLine("Store points in file");
                points.StoreInFile("test.txt");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error writing in file!");
                return;
            }

            Console.WriteLine("Clear points");
            points.Clear();

            try
            {
                Console.WriteLine("Read from file: ");
                points.LoadFromFile("test.txt");
                Console.WriteLine(points);
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error writing in file!");
                return;
            }

            // Test Problems 08 - 11
            Matrix<double> matrix1 = new Matrix<double>(5, 4);
            Matrix<double> matrix2 = new Matrix<double>(5, 4);
            Console.WriteLine("Matrix Generix");
            Console.WriteLine("------------------------------------------------");

            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 4; y++)
                {
                    matrix1[x, y] = x + y;
                    matrix2[x, y] = (x + y) * 2;
                }

            Console.WriteLine("Matrix1");
            Console.WriteLine(matrix1);

            Console.WriteLine("Matrix2");
            Console.WriteLine(matrix2);

            Console.WriteLine("Matrix1 + Matrix2");
            Console.WriteLine(matrix1 + matrix2);

            Console.WriteLine("Matrix1 - Matrix2");
            Console.WriteLine(matrix1 - matrix2);

            Console.WriteLine("Matrix1 * Matrix2");
            Console.WriteLine(matrix1 * matrix2);

            Console.WriteLine("Is matrix1 true? ");
            if (matrix1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("Attributes");
            Console.WriteLine("------------------------------------------------");

            // Reflection.
            var attrs = typeof(TestAttribute).GetCustomAttributes(typeof(VersionAttribute), true);
            
            foreach (VersionAttribute attr in attrs)
            {
                System.Console.WriteLine("Version:  {0}", attr.Version);
            }

        }

    }
}
