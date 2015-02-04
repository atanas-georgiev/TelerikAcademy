using System;

namespace Problem1
{
    class Problem1
    {
        static void Main()
        {
            double n = int.Parse(Console.ReadLine());
            double s = int.Parse(Console.ReadLine());
            double p = float.Parse(Console.ReadLine());

            string str = string.Format("{0:F3}", p);
            p = double.Parse(str);

            double realm = (n * s) / 400 * p;

            Console.WriteLine("{0:F3}", realm);
        }
    }
}
