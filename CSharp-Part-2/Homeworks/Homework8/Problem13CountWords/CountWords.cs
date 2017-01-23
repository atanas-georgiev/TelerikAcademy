//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Problem13CountWords
{
    class CountWords
    {
        static void Main()
        {
            var words = new Dictionary<string, int>();

            try
            {
                StreamReader reader1 = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
                StreamReader reader2 = new StreamReader("../../words.txt", Encoding.GetEncoding("UTF-8"));

                using (reader2)
                {
                    string line = reader2.ReadLine();

                    while (line != null)
                    {
                        words.Add(line, 0);
                        line = reader2.ReadLine();
                    }
                }

                using (reader1)
                {
                    string line = reader1.ReadLine();

                    while (line != null)
                    {
                        var wordsSeparated = line.Split(' ');

                        foreach (var item in wordsSeparated)
                        {
                            if (words.ContainsKey(item))
                            {
                                words[item]++;
                            }
                        }                        
                     
                        line = reader1.ReadLine();
                    }
                }

                StreamWriter writer = new StreamWriter("../../result.txt", false, Encoding.GetEncoding("UTF-8"));

                var result = words.OrderByDescending(x => x.Value);

                using (writer)
                {
                    foreach (var item in result)
                    {
                        writer.WriteLine(item.Key + " " + item.Value + " times.");
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
