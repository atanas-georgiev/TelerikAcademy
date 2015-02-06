//Problem 16.* Subset with sum S

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;
using System.Collections.Generic;

namespace Problem16SubsetWithSumS
{   
    class SubsetWithSumS
    {
        static List<int> l = new List<int>();
        static bool isSubsetSum(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            // If last element is greater than sum, ignore it
            if (arr[n - 1] > sum)
                return isSubsetSum(arr, n - 1, sum);

            // else, check if sum can be obtained by any of the following
            // (a) including the last element
            // (b) excluding the last element
            return isSubsetSum(arr, n - 1, sum) || isSubsetSum(arr, n - 1, sum - arr[n - 1]);
        }

        static void Main()
        {
            // Enter array length
            Console.WriteLine("Enter length of array: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("S: ");
            int s = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            // Enter values for array
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter Array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            if (isSubsetSum(array, array.Length - 1, s) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
