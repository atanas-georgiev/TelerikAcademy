using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04
{
    class Program
    {
        static string ExtendLine(string str, int lineLen)
        {
            if (str.Length == lineLen)
            {
                return str;
            }

            if (str.Contains(' ') == false)
            {
                return str;
            }

            int extend = lineLen - str.Length;
            int index = 0;

            while (extend != 0)
            {
                if (str[index] == ' ' && str[index + 1] != ' ')
                {
                    str = str.Insert(index, " ");
                    index++;
                    extend--;
                }

                index++;

                if (index >= str.Length - 1)
                {
                    index = 0;
                }
            }

            return str;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                str.Append(Console.ReadLine() + " ");
            }

            string output = System.Text.RegularExpressions.Regex.Replace(str.ToString(), @"\s+", " ");
            List<string> lines = new List<string>();
            var strings = output.Split(' ');
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < strings.Length; i++)
            {
                if (temp.Length + strings[i].Length <= w)
                {
                    temp.Append(strings[i] + " ");
                }
                else
                {
                    lines.Add(temp.ToString());
                    temp.Clear();
                    temp.Append(strings[i] + " ");
                }

                if (i == strings.Length - 1)
                {
                    lines.Add(temp.ToString());
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimEnd(' ');
            }

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = ExtendLine(lines[i], w);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine(lines[i]);
            }


        }
    }
}
