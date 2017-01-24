namespace Task08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // The majorant of an array of size N is a value that occurs in it at least N/ 2 + 1 times.
            // Write a program to find the majorant of given array (if exists).
            // Example:
            // { 2, 2, 3, 3, 2, 3, 4, 3, 3 } → 3

            var array = new[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
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

            var majorant =
                arrayOccurances
                    .Where(x => x.Value > (array.Length / 2))
                    .OrderByDescending(x => x.Key)
                    .FirstOrDefault();

            Console.WriteLine("Value {0} → {1} times", majorant.Key, majorant.Value);
        }
    }
}
