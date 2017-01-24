//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

namespace Problem14IntegerCalculations
{
    class IntegerCalculations
    {
        enum Operation
        {
            opSum,
            opAverage,
            opMax,
            opMin,
            opProduct
        }

        static int OperateInteger(Operation op, params int[] values)
        {
            int min = values[0];
            int max = values[0];
            int sum = values[0];
            int product = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }

                if (values[i] < min)
                {
                    min = values[i];
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
                    return (int)0;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter number of elements: ");
            int m = int.Parse(Console.ReadLine());
            int[] values = new int[m];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Enter number {0}: ", i + 1);
                values[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum: " + OperateInteger(Operation.opSum, values));
            Console.WriteLine("Min: " + OperateInteger(Operation.opMin, values));
            Console.WriteLine("Max: " + OperateInteger(Operation.opMax, values));
            Console.WriteLine("Average: " + OperateInteger(Operation.opAverage, values));
            Console.WriteLine("Product: " + OperateInteger(Operation.opProduct, values));
        }
    }
}
