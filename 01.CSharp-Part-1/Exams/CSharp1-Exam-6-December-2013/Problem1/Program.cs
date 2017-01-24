using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double r = 0;
            double k = 0;

            switch (b)
            {
                case 3:
                    r = a + c;
                    break;
                case 6:
                    r = a * c;
                    break;
                case 9:
                    r = a % c;
                    break;
                default:
                    break;
            }

            k = r;

            if ((r % 3) == 0)
            {
                r = r / 3;
            }
            else
            {
                r = r % 3;
            }
            Console.WriteLine(r);
            Console.WriteLine(k);
        }
    }
}
