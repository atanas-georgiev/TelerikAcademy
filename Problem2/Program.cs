using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            string x = Console.ReadLine();
            double sum = 0, cnt = 0, i = 0;
            

            foreach (var ch in x)
            {
                if ((i % 2 == 0) && char.IsDigit(ch))
                {
                    cnt++;
                    sum += (double.Parse(ch.ToString()) - double.Parse("0"));
                }
                i++;
            }
            Console.WriteLine(cnt + " " + sum);
        }
    }
}
