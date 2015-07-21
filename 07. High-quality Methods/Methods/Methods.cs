// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Methods.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The methods.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Methods
{
    using System;

    /// <summary>
    ///     The methods.
    /// </summary>
    internal class Methods
    {
        /// <summary>
        /// The calculate triangle area.
        /// </summary>
        /// <param name="sideA">
        /// The side a.
        /// </param>
        /// <param name="sideB">
        /// The side b.
        /// </param>
        /// <param name="sideC">
        /// The side c.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Invalid input values
        /// </exception>
        /// <exception cref="OverflowException">
        /// Result is too big
        /// </exception>
        private static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Input values are not correct!");
            }

            double s;

            try
            {
                s = (sideA + sideB + sideC) / 2;
            }
            catch (OverflowException)
            {
                throw new OverflowException("Input values are too big!");
            }

            var area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return area;
        }

        /// <summary>
        /// The number to digit.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Input is not a digit
        /// </exception>
        private static string NumberToDigit(int number)
        {
            if (0 > number || number > 9)
            {
                throw new ArgumentException("Input value should be positive digit number!");
            }

            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Input value should be positive digit number!");
            }
        }

        /// <summary>
        /// The find max.
        /// </summary>
        /// <param name="elements">
        /// The elements.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// No elements in the input array
        /// </exception>
        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements in the input array!");
            }

            var max = int.MinValue;
            for (var i = 0; i < elements.Length; i++)
            {
                max = Math.Max(max, elements[i]);
            }

            return max;
        }

        /// <summary>
        /// The print as number.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="format">
        /// The format.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Invalid format
        /// </exception>
        private static void PrintAsNumber(object number, string format)
        {
            string formatter;
            switch (format)
            {
                case "f":
                    formatter = "{0:f2}";
                    break;
                case "%":
                    formatter = "{0:p0}";
                    break;
                case "r":
                    formatter = "{0,8}";
                    break;
                default:
                    throw new ArgumentException("Invalid format!");
            }

            Console.WriteLine(formatter, number);
        }

        /// <summary>
        /// The calculate distance.
        /// </summary>
        /// <param name="x1">
        /// The x 1.
        /// </param>
        /// <param name="y1">
        /// The y 1.
        /// </param>
        /// <param name="x2">
        /// The x 2.
        /// </param>
        /// <param name="y2">
        /// The y 2.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// The is horizontal.
        /// </summary>
        /// <param name="y1">
        /// The y 1.
        /// </param>
        /// <param name="y2">
        /// The y 2.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool IsHorizontal(double y1, double y2)
        {
            var isHorizontal = Math.Abs(y1 - y2) < 1;
            return isHorizontal;
        }

        /// <summary>
        /// The is vertical.
        /// </summary>
        /// <param name="x1">
        /// The x 1.
        /// </param>
        /// <param name="x2">
        /// The x 2.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool IsVertical(double x1, double x2)
        {
            var isVertical = Math.Abs(x1 - x2) < 1;
            return isVertical;
        }

        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(NumberToDigit(5));
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));

            Console.WriteLine("Horizontal? " + IsHorizontal(3, 3));
            Console.WriteLine("Vertical? " + IsVertical(-1, 2.5));

            var peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");
            var stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}