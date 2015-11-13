// We are given a matrix of passable and non-passable cells.
// Write a recursive program for finding all paths between two cells in the matrix.

namespace Task07_MatrixPassableNonPassable
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static char[,] labirinth =
        {
            {' ', ' ', ' ', 'x', ' ', ' ', ' '}, 
            {'x', 'x', ' ', 'x', ' ', 'x', ' '}, 
            {' ', ' ', ' ', ' ', ' ', ' ', ' '}, 
            {' ', 'x', 'x', 'x', 'x', 'x', ' '}, 
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
        };

        public static List<Cell> path = new List<Cell>();

        public static void Main()
        {
            FindPathToExit(new Cell(0, 0), 'S');
        }

        public static bool InRange(Cell cell)
        {
            var rowInRange = cell.X >= 0 && cell.X < labirinth.GetLength(0);
            var colInRange = cell.Y >= 0 && cell.Y < labirinth.GetLength(1);
            return rowInRange && colInRange;
        }

        static void FindPathToExit(Cell cell, char direction)
        {
            if (!InRange(cell))
            {
                // bottom
                return;
            }

            path.Add(cell);

            if (labirinth[cell.X, cell.Y] == 'e')
            {
                PrintPath(path);
            }

            if (labirinth[cell.X, cell.Y] == ' ')
            {
                labirinth[cell.X, cell.Y] = 's';

                FindPathToExit(new Cell(cell.X, cell.Y - 1), 'L'); // left
                FindPathToExit(new Cell(cell.X - 1, cell.Y), 'U'); // up
                FindPathToExit(new Cell(cell.X, cell.Y + 1), 'R'); // right
                FindPathToExit(new Cell(cell.X + 1, cell.Y), 'D'); // down

                labirinth[cell.X, cell.Y] = ' ';
            }

            path.RemoveAt(path.Count - 1);
        }

        public static void PrintPath(List<Cell> path)
        {
            Console.Write("Found path to the exit: ");
            foreach (var dir in path)
            {
                Console.Write(dir);
            }
            Console.WriteLine();
        }
    }
}
