//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

namespace Problem02CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            // Enter array lengths
            Console.WriteLine("Enter length of arrays: ");
            int len = int.Parse(Console.ReadLine());

            int[] array1 = new int[len];
            int[] array2 = new int[len];

            // Enter values for array 1
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter {0} value for array 1: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Enter values for array 2
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter {0} value for array 2: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Compare arrays element by element and display result
            for (int i = 0; i < len; i++)
            {
                string simbol;

                if (array1[i] > array2[i]) simbol = ">";
                else if (array1[i] < array2[i]) simbol = "<";
                else simbol = "=";

                Console.WriteLine("Array1[{3}] = {0} {2} Array2[{3}] = {1}", array1[i], array2[i], simbol, i);
            }

        }
    }
}
