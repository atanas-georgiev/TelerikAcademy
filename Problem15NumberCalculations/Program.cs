//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

namespace Problem15NumberCalculations
{
    class Program
    {
        enum Operation
        {
            opSum,
            opAverage,
            opMax,
            opMin,
            opProduct
        }

        static T OperateGeneric<T>(Operation op, params T[] values) where T : IComparable
        {
            T min = values[0];
            T max = values[0];
            dynamic sum = values[0];
            dynamic product = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (min.CompareTo(values[i]) < 0)
                {
                    min = values[i];
                }

                if (max.CompareTo(values[i]) > 0)
                {
                    max = values[i];
                }

                sum += values[i];
                product *= values[i];
            }

            switch (op)
            {
                case Operation.opMin:
                    return min;
                case Operation.opMax:
                    return max;
                case Operation.opAverage:
                    return sum / values.Length;
                case Operation.opSum:
                    return sum;
                case Operation.opProduct:
                    return product;
                default:
                    return min;
            }
        }

        static void Main()
        {
            int[] intValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] doubleValues = { 23, 654, 213, 43523, 12321, 6533, 6535 };
            float[] floatValues = { 1.12f, 5.34f, 1234.546f, 342.6f, 1.76f, 123.532f };

            Console.WriteLine("Sum: " + OperateGeneric<int>(Operation.opSum, intValues));
            Console.WriteLine("Min: " + OperateGeneric<int>(Operation.opMin, intValues));
            Console.WriteLine("Max: " + OperateGeneric<int>(Operation.opMax, intValues));
            Console.WriteLine("Average: " + OperateGeneric<int>(Operation.opAverage, intValues));
            Console.WriteLine("Product: " + OperateGeneric<int>(Operation.opProduct, intValues));

            Console.WriteLine("Sum: " + OperateGeneric<double>(Operation.opSum, doubleValues));
            Console.WriteLine("Min: " + OperateGeneric<double>(Operation.opMin, doubleValues));
            Console.WriteLine("Max: " + OperateGeneric<double>(Operation.opMax, doubleValues));
            Console.WriteLine("Average: " + OperateGeneric<double>(Operation.opAverage, doubleValues));
            Console.WriteLine("Product: " + OperateGeneric<double>(Operation.opProduct, doubleValues));

            Console.WriteLine("Sum: " + OperateGeneric<float>(Operation.opSum, floatValues));
            Console.WriteLine("Min: " + OperateGeneric<float>(Operation.opMin, floatValues));
            Console.WriteLine("Max: " + OperateGeneric<float>(Operation.opMax, floatValues));
            Console.WriteLine("Average: " + OperateGeneric<float>(Operation.opAverage, floatValues));
            Console.WriteLine("Product: " + OperateGeneric<float>(Operation.opProduct, floatValues));
        }
    }
}
