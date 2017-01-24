namespace Task03_Deviders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        private static int n;        
        private static int[] objects;

        private static int[] arr;
        private static bool[] used;

        private static Dictionary<int, int> values; 

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            objects = new int[n];
            arr = new int[n];
            used = new bool[n];
            values = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                objects[i] = int.Parse(Console.ReadLine());
            }

            GenerateVariationsNoRepetitions(0);
            var minValues = values.Where(v => v.Value == values.Min(x => x.Value));

            if (minValues.Count() == 1)
            {
                Console.WriteLine(minValues.FirstOrDefault().Key);
            }
            else
            {
                Console.WriteLine(minValues.OrderBy(x => x.Key).FirstOrDefault().Key);
            }
            
        }

        public static int GetDividers(int value)
        {
            var result = 0;

            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    result++;
                }
            }

            return result;
        }

        public static void GenerateVariationsNoRepetitions(int index)
        {
            if (index >= n)
            {
                var intRes = int.Parse(string.Join("", arr), NumberStyles.Integer);

                try
                {
                    values.Add(intRes, GetDividers(intRes));
                }
                catch (Exception)
                {
                                        
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = objects[i];
                        GenerateVariationsNoRepetitions(index + 1);
                        used[i] = false;
                    }
                }
            }
        }        
    }
}
