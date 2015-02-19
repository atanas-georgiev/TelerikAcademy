using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("CHU", 0);
            dict.Add("TEL", 1);
            dict.Add("OFT", 2);
            dict.Add("IVA", 3);
            dict.Add("EMY", 4);
            dict.Add("VNB", 5);
            dict.Add("POQ", 6);
            dict.Add("ERI", 7);
            dict.Add("CAD", 8);
            dict.Add("K-A", 9);
            dict.Add("IIA", 10);
            dict.Add("YLO", 11);
            dict.Add("PLA", 12);

            string input = Console.ReadLine();
            double result = 0;

            for (int i = input.Length - 3, j = 0; i >= 0; i -= 3, j++)
            {
                result += dict[input.Substring(i, 3)] * Math.Pow(13, j);
            }
            Console.WriteLine(result);
        }
    }
}
