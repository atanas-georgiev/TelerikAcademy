namespace Task01_ArrayCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Write a program that counts in a given array of double values the number of occurrences of each value.Use Dictionary< TKey,TValue >.
            // Example: array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
            // -2.5-> 2 times
            // 3-> 4 times
            // 4-> 3 times
            var inputArray = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var countDict = new Dictionary<double, int>();

            foreach (var input in inputArray)
            {
                if (!countDict.ContainsKey(input))
                {
                    countDict[input] = 1;
                }
                else
                {
                    countDict[input] += 1;
                }
            }

            foreach (var countDictElement in countDict.OrderBy(x => x.Key))
            {
                Console.WriteLine("Element {0} is found {1} times.", countDictElement.Key, countDictElement.Value);
            }
        }
    }
}
