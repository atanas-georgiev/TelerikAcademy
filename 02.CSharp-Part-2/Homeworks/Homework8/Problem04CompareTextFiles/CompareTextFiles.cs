//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;
using System.Text;

namespace Problem04CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            int cntDiff = 0;
            int cntSame = 0;

            try
            {
                StreamReader reader1 = new StreamReader("../../text1.txt", Encoding.GetEncoding("UTF-8"));
                StreamReader reader2 = new StreamReader("../../text2.txt", Encoding.GetEncoding("UTF-8"));
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                using (reader1)
                {
                    using (reader2)
                    {                        
                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();

                        while ((line1 != null) && (line2 != null))
                        {
                            if (line1 == line2)
                            {
                                cntSame++;
                            }
                            else
                            {
                                cntDiff++;
                            }

                            line1 = reader1.ReadLine();
                            line2 = reader2.ReadLine();                                                       
                        }
                    }
                }

                Console.WriteLine("Same lines: " + cntSame);
                Console.WriteLine("Different lines: " + cntDiff);
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
