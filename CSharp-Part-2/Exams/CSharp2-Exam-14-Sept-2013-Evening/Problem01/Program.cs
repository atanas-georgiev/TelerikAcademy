using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("Rawr", 0);
            dict.Add("Rrrr", 1);
            dict.Add("Hsst", 2);
            dict.Add("Ssst", 3);
            dict.Add("Grrr", 4);
            dict.Add("Rarr", 5);
            dict.Add("Mrrr", 6);
            dict.Add("Psst", 7);
            dict.Add("Uaah", 8);
            dict.Add("Uaha", 9);
            dict.Add("Zzzz", 10);
            dict.Add("Bauu", 11);
            dict.Add("Djav", 12);
            dict.Add("Myau", 13);
            dict.Add("Gruh", 14);

            string input = Console.ReadLine();
            double res = 0;

            for (int i = input.Length - 4, j = 0; i >= 0; i -= 4, j++)
            {
                res += dict[input.Substring(i, 4)] * Math.Pow(15, j);
            }

            Console.WriteLine(res);
        }
    }
}
