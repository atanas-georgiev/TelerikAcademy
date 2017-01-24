// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Matrix.cs" company="">
//   
// </copyright>
// <summary>
//   The matrix.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///     The matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        ///     The directions.
        /// </summary>
        private readonly List<Point> directions = new List<Point>
                                                      {
                                                          new Point(1, 1), // down right
                                                          new Point(1, 0), // down
                                                          new Point(1, -1), // down left
                                                          new Point(0, -1), // left
                                                          new Point(-1, -1), // up left
                                                          new Point(-1, 0), // up
                                                          new Point(-1, 1), // up right
                                                          new Point(0, 1) // right
                                                      };

        /// <summary>
        ///     The matrix.
        /// </summary>
        private readonly int[,] matrix;

        /// <summary>
        ///     The current direction index.
        /// </summary>
        private int currentDirectionIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        public Matrix(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Input value should be more than 1");
            }

            this.matrix = new int[n, n];
            this.currentDirectionIndex = 0;
            this.FillMatrixValues();
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    sb.Append(string.Format("{0,3}", this.matrix[i, j]));
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        /// <summary>
        ///     The fill matrix values.
        /// </summary>
        private void FillMatrixValues()
        {
            var currentPosition = new Point(0, 0);
            var currentWriteValue = 1;

            do
            {
                this.matrix[currentPosition.X, currentPosition.Y] = currentWriteValue;
                currentPosition = this.Move(currentPosition) ?? this.GetFirstFreeCell();

                currentWriteValue++;
            }
            while (currentPosition != null);
        }

        /// <summary>
        /// The move.
        /// </summary>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        private Point Move(Point point)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newPoint = point + this.directions[i % this.directions.Count];
                if (this.IsPointInMatrixRange(newPoint) && (this.matrix[newPoint.X, newPoint.Y] == 0))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return newPoint;
                }
            }

            return null;
        }

        /// <summary>
        /// The is point in matrix range.
        /// </summary>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool IsPointInMatrixRange(Point point)
        {
            return point.X >= 0 && point.X < this.matrix.GetLength(0) && point.Y >= 0
                   && point.Y < this.matrix.GetLength(0);
        }

        /// <summary>
        ///     The get first free cell.
        /// </summary>
        /// <returns>
        ///     The <see cref="Point" />.
        /// </returns>
        private Point GetFirstFreeCell()
        {
            var p = new Point(0, 0);

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        p.X = i;
                        p.Y = j;
                        this.currentDirectionIndex = 0;
                        return p;
                    }
                }
            }

            return null;
        }
    }
}