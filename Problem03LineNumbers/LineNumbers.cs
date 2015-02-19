//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;

namespace Problem03LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter("../../out_text.txt", false, Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader)
                {
                    using (writer)
                    {
                        int cnt = 1;
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            writer.WriteLine("{0}. {1}", cnt, line);
                            line = reader.ReadLine();
                            cnt++;
                        }
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
