using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var input = new List<string>(n);

            int maxLength = 0;
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                input.Add(current);
                if (maxLength < current.Length)
                {
                    maxLength = current.Length;
                }
            }

            List<string> inputSwap = SwapWords(input, n);
            Print(inputSwap, maxLength);
        }

        static List<string> SwapWords(List<string> input, int n)
        {
            int newIndex = 0;
            for (int i = 0; i < input.Count; i++)
            {
                string current = input[i];
                newIndex = input[i].Length % (n + 1);

                input[i] = null;
                input.Insert(newIndex, current);
                input.Remove(null);
            }
            return input;
        }

        static void Print(List<string> inputSwap, int maxLength)
        {
            int currentIndex = 0;
            StringBuilder result = new StringBuilder();
            while (true)
            {
                for (int i = 0; i < inputSwap.Count; i++)
                {
                    string currentWord = inputSwap[i];
                    if (currentIndex >= currentWord.Length)
                    {
                        continue;
                    }
                    else
                    {
                        result.Append(currentWord[currentIndex]);
                    }
                }
                if (currentIndex == maxLength)
                {
                    break;
                }
                currentIndex++;
            }
            Console.WriteLine(result);
        }
    }
}