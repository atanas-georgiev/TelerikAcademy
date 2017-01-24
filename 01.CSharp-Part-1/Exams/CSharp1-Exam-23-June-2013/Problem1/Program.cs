using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            double n5 = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double moneyAmmount = n1 * 0.05 + n2 * 0.10 + n3 * 0.2 + n4 * 0.5 + n5;
          
            if (p > a)
            {
                Console.WriteLine("More {0:0.00}", (p - a));
            }
            else
            {
                if ((a - p) <= moneyAmmount)
                {
                    moneyAmmount -= (a - p);
                    Console.WriteLine("Yes {0:0.00}", moneyAmmount);
                }
                else
                {
                    Console.WriteLine("No {0:0.00}", -(moneyAmmount - (a - p)));
                }
            }

        }
    }
}
