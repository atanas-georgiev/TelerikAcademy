//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem11PrefixTest
{
    class PrefixTest
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
                            line = Regex.Replace(line, @"\b(test)\w*\b", "");
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
