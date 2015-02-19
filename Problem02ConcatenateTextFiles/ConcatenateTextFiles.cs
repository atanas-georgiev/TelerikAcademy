//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

namespace Problem02ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            try
            {
                StreamReader reader1 = new StreamReader("../../text1.txt", Encoding.GetEncoding("UTF-8"));
                StreamReader reader2 = new StreamReader("../../text2.txt", Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter("../../out_text.txt", false, Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (writer)
                {
                    using (reader1)
                    {
                        string line = reader1.ReadLine();
                        while (line != null)
                        {
                            writer.WriteLine(line);
                            line = reader1.ReadLine();
                        }                        
                    }

                    using (reader2)
                    {
                        string line = reader2.ReadLine();
                        while (line != null)
                        {
                            writer.WriteLine(line);
                            line = reader2.ReadLine();
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
