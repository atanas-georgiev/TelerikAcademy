//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem10ExtractTextFromXml
{
    class ExtractTextFromXml
    {
        public static string StripTagsRegex(string source)
        {
            return Regex.Replace(source, "<.*?>", string.Empty);
        }

        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(StripTagsRegex(line));
                        line = reader.ReadLine();
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
