//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Text;
using System.IO;

namespace Problem07ReplaceSubString
{
    class ReplaceSubString
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter("../../temp.txt", false, Encoding.GetEncoding("UTF-8"));

                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            line = line.Replace("start", "finish");
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }

                File.Delete("../../text.txt");
                File.Move("../../temp.txt", "../../text.txt");
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
