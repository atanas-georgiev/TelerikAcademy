using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Probem01
{
    class Program
    {
        static string ConvertNumbericSystem(ulong value)
        {
            List<string> codes = new List<string>();

            for (int i = 0; i < 26; i++)
            {
                codes.Add(((char)(i + 'A')).ToString());
            }

            for (int i = 26; i < 256; i++)
            {
                codes.Add(((char)((i / 26) + 'a' - 1)).ToString() + ((char)((i % 26) + 'A')).ToString());
            }

            List<string> number = new List<string>();
            do
            {
                number.Add(codes[(int)(value % 256)]);
                value /= 256;
            }
            while (value != 0);

            number.Reverse();
            return string.Join(string.Empty, number);
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ConvertNumbericSystem(ulong.Parse(input)));
        }
    }
}
