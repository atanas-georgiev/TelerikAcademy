using System;
using System.Collections.Generic;

namespace Problem5
{
    class Problem5
    {
        static List<string> input = new List<string>();
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input.Add(Convert.ToString(uint.Parse(Console.ReadLine()), 2));
                input[i] = input[i].PadLeft(input[i].Length + 30, '0');
                input[i] = input[i].Substring(input[i].Length - 30, 30);
            }

            string final = "";

            for (int i = 0; i < n; i++)
            {
                final += input[i];
            }

            int numCurrSeq0 = 1;
            int longestSeq0 = 0;
            int numCurrSeq1 = 1;
            int longestSeq1 = 0;

            for (int i = 0; i < final.Length - 1; i++)
            {
                if ((final[i] == '0') && (final[i + 1] == '0'))
                {
                    numCurrSeq0++;
                }
                else
                {
                    numCurrSeq0 = 1;
                }

                if ((final[i] == '1') && (final[i + 1] == '1'))
                {
                    numCurrSeq1++;
                }
                else
                {
                    numCurrSeq1 = 1;
                }

                if (longestSeq0 < numCurrSeq0)
                {
                    longestSeq0 = numCurrSeq0;
                }

                if (longestSeq1 < numCurrSeq1)
                {
                    longestSeq1 = numCurrSeq1;
                }
            }

            bool found = false;
            for (int i = 0; i < final.Length - 1; i++)
            {
                if (final[i] == '0')
                {
                    found = true;
                }
            }

            if (found == false) longestSeq0 = 0;

            found = false;
            for (int i = 0; i < final.Length - 1; i++)
            {
                if (final[i] == '1')
                {
                    found = true;
                }
            }

            if (found == false) longestSeq1 = 0;

            Console.WriteLine(longestSeq1);
            Console.WriteLine(longestSeq0);
        }
    }
}