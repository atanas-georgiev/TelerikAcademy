using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem05
{
    class Permute
    {
        public HashSet<string> hash = new HashSet<string>();

        private void swap(ref char a, ref char b)
        {
            if (a == b)
                return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public void setper(char[] list)
        {
            int x = list.Length - 1;
            go(list, 0, x);
        }

        private void go(char[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                hash.Add(new string(list));
            }
            else
                for (i = k; i <= m; i++)
                {
                    swap(ref list[k], ref list[i]);
                    go(list, k + 1, m);
                    swap(ref list[k], ref list[i]);
                }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            Permute p = new Permute();
            string c = Console.ReadLine();
            char[] c2 = c.ToCharArray();
            /* Calling the permute */
            p.setper(c2);

            //for (int i = 0; i < p.hash. - 1; i++)
            //{
            //    if (list[i] == list[i + 1])
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //if (found == false) Count++;
            //Console.WriteLine(p.Count);      

        }



    }
}
