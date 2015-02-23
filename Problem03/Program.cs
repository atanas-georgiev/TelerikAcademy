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
        private int W, H, D;
        private int layer;
        public Cuboid(int w, int h, int d)
        {
            W = w;
            H = h;
            D = d;
            cube = new Cell[W, H, D];
        }

        public void AddLayer(int height, string layer)
        {
            var elements =
            Regex.Matches(layer.Replace(Environment.NewLine, ""), @"\((.*?)\)")
                .Cast<Match>()
                .Select(x => x.Groups[1].Value)
                .ToList();

            int width = 0;
            int depth = 0;

            foreach (string match in elements)
            {
                string[] temp = match.Split(' ');
                Cell newCell = new Cell();

                switch (temp[0])
                {
                    case "S":
                        newCell.type = CellType.Slide;
                        switch (temp[1])
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
                    case "E":
                        newCell.type = CellType.Empty;
                        break;
                    case "B":
                        newCell.type = CellType.Basket;
                        break;
                    default:
                        break;
                }

                cube[width, height, depth] = newCell;
                depth++;

                if (depth >= D)
                {
                    depth = 0;
                    width++;
                }
            }
        }

        public Point3d Slide(int x, int y)
        {
            Point3d point = new Point3d();
            point.X = x;
            point.Y = y;
            point.Z = 0;
            point.isOut = true;

            for (int i = 0; i < H; i++)
            {                
                switch (cube[point.X, i, point.Y].type)
                {
                    case CellType.Slide:
                        switch (cube[point.X, i, point.Y].data1)
                        {
                            case 0:
                                point.Y -= 1;
                                break;
                            case 1:
                                point.Y += 1;
                                break;
                            case 2:
                                point.X += 1;
                                break;
                            case 3:
                                point.Y -= 1;
                                break;
                            case 4:
                                point.X += 1;
                                point.Y -= 1;
                                break;
                            case 5:
                                point.X += 1;
                                point.Y += 1;
                                break;
                            case 6:
                                point.X -= 1;
                                point.Y -= 1;
                                break;
                            case 7:
                                point.X -= 1;
                                point.Y += 1;
                                break;
                            default:
                                break;
                        }
                        break;
                    case CellType.Teleport:
                        point.X = cube[point.X, i, point.Y].data1;
                        point.Y = cube[point.X, i, point.Y].data2;
                        break;
                    case CellType.Empty:
                        break;
                    case CellType.Basket:
                        point.isOut = false;
                        return point;
                    default:
                        break;
                }
                point.Z++;
            }

            return point;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid c = new Cuboid(3, 3, 3);
            c.AddLayer(0, "(S L)(E)(S L) | (S L)(S R)(S L) | (B)(S F)(S L) ");
            c.AddLayer(1, "(S B)(S F)(E) | (S B)(S F)(T 1 1)  | (S L)(S R)(B) ");
            c.AddLayer(2, "(S FL)(S FL)(S FR) | (S FL)(S FL)(S FR) | (S F)(S BR)(S FR) ");

            Point3d p = c.Slide(1, 1);
        }
    }
}
