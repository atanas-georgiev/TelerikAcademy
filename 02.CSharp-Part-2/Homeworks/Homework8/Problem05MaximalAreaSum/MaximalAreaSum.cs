//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Text;

namespace Problem05MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main()
        {
            int size = 0;
            int[,] array;

            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader)
                {
                    size = int.Parse(reader.ReadLine());
                    array = new int[size, size];

                    for (int i = 0; i < size; i++)
                    {
                        string[] numbers = reader.ReadLine().Split(' ');

                        for (int j = 0; j < size; j++)
                        {
                            array[i, j] = int.Parse(numbers[j]);
                        }
                    }
                }

                int max = int.MinValue;

                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        if (array[i, j] + array[i + 1, j] + array[i, j + 1] + array[i + 1, j + 1] > max)
                        {
                            max = array[i, j] + array[i + 1, j] + array[i, j + 1] + array[i + 1, j + 1];
                        }
                    }
                }

                StreamWriter writer = new StreamWriter("../../out_text.txt", false, Encoding.GetEncoding("UTF-8"));

                using (writer)
                {
                    writer.Write(max);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Can not find file!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.WriteLine("Can not open the file!");
            }
        }
    }
}
