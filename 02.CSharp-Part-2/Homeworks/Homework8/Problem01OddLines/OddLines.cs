//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

namespace Problem01OddLines
{
    class OddLines
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader)
                {
                    int cnt = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        if (cnt % 2 == 1)
                        {
                            Console.WriteLine(line);
                        }
                        line = reader.ReadLine();
                        cnt++;
                    }
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
