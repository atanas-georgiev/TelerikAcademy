using System;

namespace Problem2
{
    class Problem2
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int result = 0;

            foreach (char ch in str)
            {
                if (ch == '@')
                {
                    break;
                }
                else if (Char.IsDigit(ch) == true)
                {
                    result *= (ch - '0');
                }
                else if ((ch >= 'a') && (ch <= 'z'))
                {
                    result += ch - 'a';
                }
                else if ((ch >= 'A') && (ch <= 'Z'))
                {
                    result += ch - 'A';
                }
                else
                {
                    result %= m;
                }
            }

            Console.WriteLine(result);
        }
    }
}
