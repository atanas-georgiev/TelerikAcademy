using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem03
{
    enum CellType
    {
        Slide,
        Teleport,
        Empty,
        Basket
    }

    struct Cell
    {
        public CellType type;
        public int data1, data2;
    }

    struct Point3d
    {
        public int X;
        public int Y;
        public int Z;
        public bool isOut;
    }

    class Cuboid
    {
        private Cell[, ,] cube;
        private int X, Y, Z;
        public Cuboid(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            cube = new Cell[X, Y, Z];
        }

        public void AddLayer(int z, string layer)
        {
            var elements =
            Regex.Matches(layer.Replace(Environment.NewLine, ""), @"\((.*?)\)")
                .Cast<Match>()
                .Select(m => m.Groups[1].Value)
                .ToList();

            int x = 0;
            int y = 0;

            foreach (string match in elements)
            {
                string[] temp = match.Split(' ');
                Cell newCell = new Cell();

                switch (temp[0].Trim().ToUpper())
                {
                    case "S":
                        newCell.type = CellType.Slide;
                        switch (temp[1].Trim().ToUpper())
                        {
                            case "L":
                                newCell.data1 = 0;
                                break;
                            case "R":
                                newCell.data1 = 1;
                                break;
                            case "F":
                                newCell.data1 = 2;
                                break;
                            case "B":
                                newCell.data1 = 3;
                                break;
                            case "FL":
                                newCell.data1 = 4;
                                break;
                            case "FR":
                                newCell.data1 = 5;
                                break;
                            case "BL":
                                newCell.data1 = 6;
                                break;
                            case "BR":
                                newCell.data1 = 7;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "T":
                        newCell.type = CellType.Teleport;
                        newCell.data1 = int.Parse(temp[1]);
                        newCell.data2 = int.Parse(temp[2]);
                        break;
                    case "E":
                        newCell.type = CellType.Empty;
                        break;
                    case "B":
                        newCell.type = CellType.Basket;
                        break;
                    default:
                        break;
                }

                cube[x, y, z] = newCell;
                x++;

                if (x >= X)
                {
                    x = 0;
                    y++;
                }
            }
        }

        public Point3d Slide(int x, int y)
        {
            bool isOut = true;
            int z = 0;

            for (z = 0; z < Z; z++)
            {
                switch (cube[x, y, z].type)
                {
                    case CellType.Slide:
                        if (z < Z - 1)
                        {
                            switch (cube[x, y, z].data1)
                            {
                                case 0: // L
                                    x -= 1;
                                    break;
                                case 1: // R
                                    x += 1;
                                    break;
                                case 2: // F
                                    y -= 1;
                                    break;
                                case 3: // B
                                    y += 1;
                                    break;
                                case 4: // FL
                                    y -= 1;
                                    x -= 1;
                                    break;
                                case 5: // FR
                                    y -= 1;
                                    x += 1;
                                    break;
                                case 6: // BL
                                    y += 1;
                                    x -= 1;
                                    break;
                                case 7: // BR
                                    y += 1;
                                    x += 1;
                                    break;
                                default:
                                    break;
                            }

                            if (x < 0) { x += 1; isOut = false; }
                            if (y < 0) { y += 1; ; isOut = false; }
                            if (x >= X) { x -= 1; isOut = false; }
                            if (y >= Y) { y -= 1; ; isOut = false; }
                        }
                        break;
                    case CellType.Teleport:
                        int temp1, temp2;
                        temp1 = cube[x, y, z].data1;
                        temp2 = cube[x, y, z].data2;
                        x = temp1;
                        y = temp2;
                        z -= 1;
                        break;
                    case CellType.Basket:
                        isOut = false;
                        break;
                    case CellType.Empty:
                        break;
                    default:
                        break;
                }

                if (isOut == false)
                {
                    break;
                }
            }

            if (z >= Z) { z = Z - 1; }
            Point3d point = new Point3d();
            point.X = x;
            point.Y = y;
            point.Z = z;
            point.isOut = isOut;

            return point;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputPath = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int x = inputPath[0];
            int y = inputPath[2];
            int z = inputPath[1];

            Cuboid c = new Cuboid(x, y, z);

            for (int i = 0; i < z; i++)
            {
                c.AddLayer(i, Console.ReadLine());
            }

            int[] start = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            Point3d p = c.Slide(start[0], start[1]);

            Console.WriteLine("{0}", p.isOut == true ? "Yes" : "No");
            Console.WriteLine("{0} {1} {2}", p.X, p.Z, p.Y);
        }
    }
}