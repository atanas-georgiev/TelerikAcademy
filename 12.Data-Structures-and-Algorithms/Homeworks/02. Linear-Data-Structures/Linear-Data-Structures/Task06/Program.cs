namespace Task06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that removes from given sequence all numbers that occur odd number of times.
            // Example:
            // {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}

            var array = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
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

            foreach (var value in arrayOccurances.Where(x => x.Value % 2 == 1))
            {
                array.RemoveAll(x => x == value.Key);
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
