using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int tableCount = int.Parse(Console.ReadLine());

            List<int> codes = new List<int>();
            Dictionary<int, string> table = new Dictionary<int, string>();

            foreach (string item in input)
            {
                codes.Add(int.Parse(item));
            }

            for (int i = 0; i < tableCount; i++)
            {
                string str = Console.ReadLine();
                int len = int.Parse(str.Substring(1, str.Length - 1));
                table.Add(len, str[0].ToString());
            }

            string codeInBin = "";
            foreach (int code in codes)
            {
                codeInBin += Convert.ToString(code, 2).PadLeft(8, '0');
            }

            codeInBin = codeInBin.TrimEnd('0');

            string[] splitWords = codeInBin.Split('0');
            var words = splitWords.Select(x => x.Length).ToArray();
            string result = "";

            foreach (int item in words)
            {
                result += table[item];
            }

            Console.WriteLine(result);
        }
    }
}
