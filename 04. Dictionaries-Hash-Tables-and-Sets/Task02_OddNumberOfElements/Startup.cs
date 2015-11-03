namespace Task02_OddNumberOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.Example:
            // { C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
            var inputElements = new[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var countDict = new Dictionary<string, int>();

            foreach (var input in inputElements)
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

            var result = countDict.Where(x => (x.Value % 2 == 1)).Select(y => y.Key).ToList();
            Console.WriteLine("Elements presented odd number of times: " + string.Join(", ", result));
        }
    }
}
