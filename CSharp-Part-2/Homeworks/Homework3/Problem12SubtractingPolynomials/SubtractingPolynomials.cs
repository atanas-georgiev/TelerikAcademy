//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

namespace Problem12SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        enum Operation
        {
            Sum,
            Substract,
            Multipy
        }

        static int[] OperatePolynomial(int[] arr1, int[] arr2, Operation op)
        {
            int[] res = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                switch (op)
                {
                    case Operation.Sum:
                        res[i] = arr1[i] + arr2[i];
                        break;
                    case Operation.Substract:
                        res[i] = arr1[i] - arr2[i];
                        break;
                    case Operation.Multipy:
                        res[i] = arr1[i] * arr2[i];
                        break;
                    default:
                        break;
                }
            }

            return res;
        }

        static void Main()
        {
            Console.WriteLine("Add size of polynomials: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter polynomial 1 index {0}", i);
                arr1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter polynomial 2 index {0}", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] res = OperatePolynomial(arr1, arr2, Operation.Multipy);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("Result polynomial index {0} = {1}", i, res[i]);
            }
        }
    }
}
