using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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

            // 1.	If there are less than i cages, the factory stops the multiplication process.
            while (cycle <= cages.Count)
            {
                BigInteger sum = 0;
                BigInteger sum1 = 0;
                BigInteger product = 1;

                // 2.	The factory gets the first i cages and calculate the sum s of all bunnies in them. 
                for (int i = 0; i < cycle; i++)
                {
                    sum += cages[i];
                }


                // 3.	If there are less than s cages after the i-th one, the factory stops the multiplication process.
                if (sum > cages.Count - cycle)
                {
                    break;
                }

                sum1 = 0;

                // 4.	The factory gets the next s cages after the i-th one and calculates the sum and product of all bunnies in them. 
                for (int i = cycle; i < cycle + sum; i++)
                {
                    sum1 += cages[i];
                    product *= cages[i];
                }

                // 5.	These sum and product are concatenated as next cages. All cages that were not included in the calculations are simply appended to next.
                string result = sum1.ToString() + product.ToString();
                for (int i = cycle + (int)sum; i < cages.Count; i++)
                {
                    result += cages[i].ToString();
                }

                // 6.	The factory gets several empty cages then gets the digits of next and for each digit puts the same amount of bunnies in each cell. If the digit is 1 or 0, the digit is ignored.
                cages.Clear();
                foreach (char ch in result)
                {
                    if (ch != '0' && ch != '1')
                    {
                        cages.Add(int.Parse(ch.ToString()));
                    }
                }

                // 7.	Step 1 is repeated for the newly generated cages with bunnies.
                cycle++;
            }

            foreach (int value in cages)
            {
                Console.Write(value + " ");
            }
        }
    }
}
