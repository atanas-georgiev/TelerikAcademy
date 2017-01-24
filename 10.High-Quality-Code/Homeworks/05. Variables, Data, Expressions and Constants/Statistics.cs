// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Statistics.cs" company="Telerik">
//   Homework HQC
// </copyright>
// <summary>
//   The size.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace VariablesDataExpressions
{
    using System;

    /// <summary>
    ///     The statistics.
    /// </summary>
    internal class Statistics
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="inputArray">
        /// The input array.
        /// </param>
        /// <param name="count">
        /// The count.
        /// </param>
        public void Print(double[] inputArray, int count)
        {
            var maxValue = double.MinValue;
            for (var i = 0; i < count; i++)
            {
                if (inputArray[i] > maxValue)
                {
                    maxValue = inputArray[i];
                }
            }

            this.PrintMax(maxValue);

            var minValue = double.MaxValue;
            for (var i = 0; i < count; i++)
            {
                if (inputArray[i] < minValue)
                {
                    minValue = inputArray[i];
                }
            }

            this.PrintMin(minValue);

            var sumValues = 0d;
            for (var i = 0; i < count; i++)
            {
                sumValues += inputArray[i];
            }

            var average = sumValues / count;
            this.PrintAvg(average);
        }

        /// <summary>
        /// The print max.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        private void PrintMax(double value)
        {
            Console.WriteLine("Maximul value is " + value);
        }

        /// <summary>
        /// The print min.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        private void PrintMin(double value)
        {
            Console.WriteLine("Minimum value is " + value);
        }

        /// <summary>
        /// The print average.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        private void PrintAvg(double value)
        {
            Console.WriteLine("Average value is " + value);
        }
    }
}