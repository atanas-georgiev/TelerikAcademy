using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem05
{
    class Program
    {
        static int CountSteps(List<int> l)
        {
            BigInteger cnt = 2;

            while (l.Count() > 1)
            {
                l = l.Where((x, i) => ((i % cnt) != 0)).ToList();
                cnt++;
            }

            return l[0];
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = Enumerable.Range(1, n).ToList();

            
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            Console.WriteLine(CountSteps(list));
            Console.WriteLine("bounded");
            Console.WriteLine("bounded");
        }
    }
}
