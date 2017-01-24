//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace Problem03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            // Enter array lengths
            Console.WriteLine("Enter length of arrays: ");
            int len = int.Parse(Console.ReadLine());

            char[] array1 = new char[len];
            char[] array2 = new char[len];

            // Enter values for array 1
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter {0} value for array 1: ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }

            // Enter values for array 2
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter {0} value for array 2: ", i);
                array2[i] = char.Parse(Console.ReadLine());
            }

            // Compare arrays element by element and display result
            for (int i = 0; i < len; i++)
            {
                string simbol;

                if (array1[i] > array2[i]) simbol = "greater than";
                else if (array1[i] < array2[i]) simbol = "less than";
                else simbol = "the same as";

                Console.WriteLine("Array1[{3}] = {0} {2} Array2[{3}] = {1}", array1[i], array2[i], simbol, i);
            }

        }
    }
}