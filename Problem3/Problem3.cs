using System;
using System.Numerics;
using System.Collections.Generic;

namespace Problem3
{
    class Problem3
    {
        static void Main()
        {
            checked
            {
                List<ulong> values = new List<ulong>();
                ulong sum = 0;
                ulong loops = 1;
                ulong input = ulong.Parse(Console.ReadLine());
                string str = input.ToString();

                while (true)
                {
                    while (str.Length != 0)
                    {
                        str = str.Remove(str.Length - 1);
                        sum = 0;

                        for (int i = 0; i < str.Length; i++)
                        {
                            if ((i % 2) == 1)
                            {
                                sum += (ulong)(str[i] - '0');
                            }
                        }

                        if (sum != 0)
                        {
                            values.Add(sum);
                        }
                    }

                    BigInteger product;

                    if (values.Count > 0)
                    {
                        product = values[0];
                        for (int i = 1; i < values.Count; i++)
                        {
                            product *= values[i];
                        }
                    }
                    else
                    {
                        product = 1;
                    }

                    str = product.ToString();
                    if (product < 10)
                    {
                        Console.WriteLine(loops);
                        Console.WriteLine(product);
                        return;
                    }
                    else if (loops == 10)
                    {
                        Console.WriteLine(product);
                        return;
                    }

                    values.Clear();
                    loops++;
                }
            }
        }
    }
}
