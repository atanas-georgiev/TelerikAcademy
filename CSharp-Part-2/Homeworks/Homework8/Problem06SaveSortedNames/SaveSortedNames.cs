//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Problem06SaveSortedNames
{
    class SaveSortedNames
    {        
        static void Main()
        {
            List<string> names = new List<string>();

            try
            {
                StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        names.Add(line);
                        line = reader.ReadLine();                        
                    }
                }

                var sortedNames = names.OrderBy(x => x).ToList();

                StreamWriter writer = new StreamWriter("../../out_text.txt", false, Encoding.GetEncoding("UTF-8"));

                using (writer)
                {
                    foreach (var name in sortedNames)
                    {
                        writer.WriteLine(name);
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
