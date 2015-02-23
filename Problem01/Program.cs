using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static string ConvertNumbericSystem(ulong value)
        {
            string[] dict = new string[9];

            dict[0] = @"LON+";
            dict[1] = @"VK-";
            dict[2] = @"*ACAD";
            dict[3] = @"^MIM";
            dict[4] = @"ERIK|";
            dict[5] = @"SEY&";
            dict[6] = @"EMY>>";
            dict[7] = @"/TEL";
            dict[8] = @"<<DON";

            List<string> tresNumber = new List<string>();
            do
            {
                tresNumber.Add(dict[value % 9]);

                value /= 9;
            }
            while (value != 0);

            tresNumber.Reverse();
            return string.Join(string.Empty, tresNumber);
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string res = ConvertNumbericSystem(ulong.Parse(input));

            Console.WriteLine(res);
        }
    }
}
