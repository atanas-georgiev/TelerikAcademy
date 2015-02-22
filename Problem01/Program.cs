using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static string ConvertNumbericSystem(string value, int base1, int base2)
        {
            ulong decRepresentation = 0;

            // base 1 to decimal system
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(value[i]))
                {
                    decRepresentation += (ulong)((value[i] - '0') * Math.Pow(base1, value.Length - i - 1));
                }
                else
                {
                    int num = 0;

                    switch (value[i])
                    {
                        case 'a':
                        case 'A':
                            num = 10;
                            break;
                        case 'b':
                        case 'B':
                            num = 11;
                            break;
                        case 'c':
                        case 'C':
                            num = 12;
                            break;
                        case 'd':
                        case 'D':
                            num = 13;
                            break;
                        case 'e':
                        case 'E':
                            num = 14;
                            break;
                        case 'f':
                        case 'F':
                            num = 15;
                            break;
                        default:
                            break;
                    }

                    decRepresentation += (ulong)(num * Math.Pow(base1, value.Length - i - 1));
                }
            }

            ulong remainder;
            string result = string.Empty;

            while (decRepresentation > 0)
            {
                remainder = (ulong)(decRepresentation % (ulong)base2);
                decRepresentation /= (ulong)base2;

                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    switch (remainder)
                    {
                        case 10:
                            result = "A" + result;
                            break;
                        case 11:
                            result = "B" + result;
                            break;
                        case 12:
                            result = "C" + result;
                            break;
                        case 13:
                            result = "D" + result;
                            break;
                        case 14:
                            result = "E" + result;
                            break;
                        case 15:
                            result = "F" + result;
                            break;
                        default:
                            break;
                    }
                }
            }
            return result;
        }

        static void Main()
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

            string input = Console.ReadLine();
            string res = ConvertNumbericSystem(input, 10, 9);
            string res1 = "";

            foreach (char ch in res)
            {
                res1 += dict[ch - '0'];
            }

            Console.WriteLine(res1);
        }
    }
}
