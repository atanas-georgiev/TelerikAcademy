namespace Task03_WordsSet
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Task03_WordsSet.Trie;

    public class Program
    {
        private const string InputFileName = @"Ivan_Vazov_Pod_Igoto.txt";

        public static void Main()
        {
            ITrie<int> trie = new SuffixTrie<int>(3);

            // Read words from file
            var words = File.ReadAllText(InputFileName, Encoding.UTF8).Split(new[] { ' ' });

            //Look-up
            LookUp("много", trie);
            LookUp("се", trie);
            LookUp("така", trie);
        }

        private static void LookUp(string searchString, ITrie<int> trie)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Look-up for string '{0}'", searchString);
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] result = trie.Retrieve(searchString).ToArray();
            stopWatch.Stop();

            string matchesText = String.Join(",", result);
            int matchesCount = result.Count();

            if (matchesCount == 0)
            {
                Console.WriteLine("No matches found.\tTime: {0}", stopWatch.Elapsed);
            }
            else
            {
                Console.WriteLine(" {0} matches found. \tTime: {1}\tLines: {2}",
                              matchesCount,
                              stopWatch.Elapsed,
                              matchesText);
            }
        }
    }
}
