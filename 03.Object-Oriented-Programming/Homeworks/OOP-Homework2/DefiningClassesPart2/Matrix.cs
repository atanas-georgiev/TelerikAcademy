using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 8. Matrix
    /// Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
    /// </summary>
    class Matrix<T> where T : IConvertible
    {
        private T[,] innerMatrix;

        public int Rows { get; set; }
        public int Cols { get; set; }
        /// <summary>
        /// Problem 9. Matrix indexer
        /// Implement an indexer this[row, col] to access the inner matrix cells.
        /// </summary>
        public T this[int x, int y]
        {
            get
            {
                return innerMatrix[x, y];
            }

            set
            {
                innerMatrix[x, y] = value;
            }
        }

        public Matrix() { }

        public Matrix(int rows, int cols)
            : this()
        {
            innerMatrix = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

        /// <summary>
        /// Problem 10. Matrix operations
        /// Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
        /// Throw an exception when the operation cannot be performed.
        /// Implement the true operator (check for non-zero elements).
        /// </summary>
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] + (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] - (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] * (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

                public static bool operator true(Matrix<T> m1)
        {
            if (m1 != null)
            {
                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        if (m1[x, y] != (dynamic)0)
                        {
                            return true;
                        }

                return false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool operator false(Matrix<T> m1)
        {
            if (m1 != null)
            {
                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        if (m1[x, y] == (dynamic)0)
                        {
                            return true;
                        }

                return false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int x = 0; x < this.Rows; x++)
            {
                for (int y = 0; y < this.Cols; y++)
                {
                    str.Append(this.innerMatrix[x, y] + " ");
                }
                str.Append("\n");
            }
            return str.ToString();
        }
    }
}
