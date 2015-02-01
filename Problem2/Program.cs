using System;

namespace Problem2
{
    class Program
    {
        static int M, V;

        static void CalcNumber(int n)
        {
            string str = n.ToString();
            str = str.TrimStart('0');

            int digits = str.Length;
            if (digits > 9) digits = 9;

            if ((digits % 2) == 0)
            {
                digits = digits / 2;
            }
            else
            {
                digits = digits / 2 + 1;
            }

            for (int i = 0; i < digits; i++)
            {
                M += str[i] - '0';
            }

            for (int i = str.Length - 1; i > str.Length - digits - 1; i--)
            {
                V += str[i] - '0';
            }

        }


        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < rounds; i++)
            {
                int n = int.Parse(Console.ReadLine());
                CalcNumber(n);
            }

            if (V > M)
            {
                Console.WriteLine("V " + (V - M));
            }
            else if (M > V)
            {
                Console.WriteLine("M " + (M - V));
            }
            else
            {
                Console.WriteLine("No " + (V + M));
            }
        }
    }
}
