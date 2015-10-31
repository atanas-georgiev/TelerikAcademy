namespace Task07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds in given array of integers (all belonging to the range[0..1000]) how many times each of them occurs.

            // Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}
            //            2 → 2 times
            //            3 → 4 times
            //            4 → 3 times

            var array = new[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var arrayOccurances = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (arrayOccurances.ContainsKey(value))
                {
                    arrayOccurances[value] += 1;
                }
                else
                {
                    arrayOccurances[value] = 1;
                }
            }

            foreach (var value in arrayOccurances.OrderBy(x => x.Key))
            {
                Console.WriteLine("Value {0} → {1} times", value.Key, value.Value);
            }
        }
    }
}
