using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static string ExtractWords(string[] str)
        {
            StringBuilder s = new StringBuilder();
            bool LeftWords = true;

            while (LeftWords)
            {
                LeftWords = false;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != "")
                    {
                        LeftWords = true;
                        s.Append(str[i][str[i].Length - 1]);
                        str[i] = str[i].Substring(0, str[i].Length - 1);
                    }
                }
            }
            return s.ToString();
        }

        static string MoveLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                int pos = ((Char.ToLower(str[i]) - 'a' + 1 + i) % str.Length);
                str = str.Remove(i, 1);
                if (pos < str.Length)
                {
                    str = str.Insert(pos, ch.ToString());
                }
                else
                {
                    str += ch.ToString();
                }
            }
            return str;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Console.WriteLine(MoveLetters(ExtractWords(words)));
        }
    }
}
