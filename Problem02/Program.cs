using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cages = new List<int>();
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                cages.Add(int.Parse(input));
            }

            int cycle = 1;

            while (cycle < cages.Count)
            {
                int sum = 0;
                int sum1 = 0;
                int product = 1;

                for (int i = 0; i < cycle; i++)
                {
                    sum += cages[i];
                }

                if (sum > cages.Count - cycle)
                {
                    break;
                }

                sum1 = 0;

                for (int i = cycle; i < cycle + sum; i++)
                {
                    sum1 += cages[i];
                    product *= cages[i];
                }

                string result = sum1.ToString() + product.ToString();

                for (int i = cycle + sum; i < cages.Count; i++)
                {
                    result += cages[i].ToString();
                }

                cages.Clear();

                foreach (char ch in result)
                {
                    if (ch != '0' && ch != '1')
                    {
                        cages.Add(int.Parse(ch.ToString()));
                    }
                }

                cycle++;
            }

            foreach (int value in cages)
            {
                Console.Write(value + " ");
            }
        }
    }
}
