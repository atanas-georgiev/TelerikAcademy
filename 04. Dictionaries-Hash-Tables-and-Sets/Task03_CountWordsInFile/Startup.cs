namespace Task03_CountWordsInFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string FileName = "words.txt";

        public static void Main()
        {
            string text = null;

            try
            {
                text = File.ReadAllText(FileName);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            if (text != null)
            {
                var words = text.Split(new char[] { ' ', ',', '–', '.', '!', '?' }).Where(x => !string.IsNullOrEmpty(x));
                var countDict = new Dictionary<string, int>();

                foreach (var input in words)
                {
                    if (!countDict.ContainsKey(input.ToLower()))
                    {
                        countDict[input.ToLower()] = 1;
                    }
                    else
                    {
                        countDict[input.ToLower()] += 1;
                    }
                }

                foreach (var countDictElement in countDict.OrderBy(x => x.Value))
                {
                    Console.WriteLine("Element {0} is found {1} times.", countDictElement.Key, countDictElement.Value);
                }
            }
        }
    }
}
