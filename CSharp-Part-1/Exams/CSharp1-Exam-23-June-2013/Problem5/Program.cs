using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem5
{
    public static class IntExtensions
    {
        public static uint SetBit(this uint target, int field, bool value)
        {
            field = 31 - field;
            if (value == true)
            {
                return (uint)(target | (1 << field));
            }
            else
            {
                return (uint)(target & ~(1 << field));
            }
        }

        public static bool GetBit(this uint target, int field)
        {
            field = 31 - field;
            return (target & (1 << field)) != 0;
        }
    }

    class Program
    {
        static List<uint> input = new List<uint>();
        static List<uint> output = new List<uint>();

        static bool IsInside(int x, int y)
        {
            bool[] bBorder = { false, false, false, false };

            int temp;

            temp = x - 1;
            while (temp >= 0)
            {
                if ((input[temp].GetBit(y)) == true)
                {
                    bBorder[0] = true;
                    break;
                }
                temp--;
            }

            temp = x + 1;
            while (temp < input.Count)
            {
                if ((input[temp].GetBit(y)) == true)
                {
                    bBorder[1] = true;
                    break;
                }
                temp++;
            }

            temp = y - 1;
            while (temp >= 0)
            {
                if ((input[x].GetBit(temp)) == true)
                {
                    bBorder[2] = true;
                    break;
                }
                temp--;
            }

            temp = y + 1;
            while (temp < 32)
            {
                if ((input[x].GetBit(temp)) == true)
                {
                    bBorder[3] = true;
                    break;
                }
                temp++;
            }

            if ((bBorder[0] == true) && (bBorder[1] == true) && (bBorder[2] == true) && (bBorder[3] == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {



            while (true)
            {
                long x = long.Parse(Console.ReadLine());

                if (x >= 0)
                {
                    input.Add((uint)x);
                }
                else
                {
                    break;
                }
            }

            //input.Add(0);
            //input.Add(0);
            //input.Add(16252928);
            //input.Add(50593792);
            //input.Add(33685504);
            //input.Add(67239936);
            //input.Add(67174400);
            //input.Add(33587200);
            //input.Add(16809984);
            //input.Add(16973824);
            //input.Add(8650752);
            //input.Add(7864320);
            //input.Add(0);


            //foreach (var i in input)
            //{
            //    Console.WriteLine("{0}", Convert.ToString(i, 2).PadLeft(32, '0'));
            //}


            for (int i = 0; i < input.Count; i++)
            {
                uint temp = 0;

                for (int k = 0; k < 32; k++)
                {
                    if (input[i].GetBit(k) == true)
                    {
                        temp = temp.SetBit(k, false);
                    }
                    else
                    {
                        bool res = IsInside(i, k);
                        if (res == true)
                        {
                            temp = temp.SetBit(k, true);
                        }
                        else
                        {
                            temp = temp.SetBit(k, false);
                        }
                    }
                }
                output.Add(temp);
            }

            Console.WriteLine();

            foreach (var i in output)
            {
                //Console.WriteLine("{0}", Convert.ToString(i, 2).PadLeft(32, '0'));
                Console.WriteLine(i);
            }
        }
    }
}
