namespace Task02_Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static Dictionary<int, int> rabbits = new Dictionary<int, int>();

        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var rabbit = int.Parse(Console.ReadLine());

                if (!rabbits.ContainsKey(rabbit))
                {
                    rabbits.Add(rabbit, 1);
                }
                else
                {
                    rabbits[rabbit] += 1;
                }                
            }

            var result = 0;

            foreach (var rabbit in rabbits)
            {
                if (rabbit.Value <= rabbit.Key + 1)
                {
                    result += rabbit.Key + 1;
                }
                else
                {
                    result += (rabbit.Key + 1) * (int)((rabbit.Value / (rabbit.Key + 1)) + 1);
                }
            }

            Console.WriteLine(result);
        }
    }
}
