using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

            var numbersList = new List<int>();

            do
            {
                Console.WriteLine("Enter number: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    // exit
                    break;
                }

                numbersList.Add(int.Parse(input));
            }
            while (true);

            foreach (var val in SortList(numbersList))
            {
                Console.WriteLine(val);
            }

        }

        public static List<int> SortList(List<int> list)
        {
            int length = list.Count;

            int temp = list[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];

                        list[i] = list[j];

                        list[j] = temp;
                    }
                }
            }

            return list;
        }
    }
}
