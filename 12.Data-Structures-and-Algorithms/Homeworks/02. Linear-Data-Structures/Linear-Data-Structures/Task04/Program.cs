namespace Task04
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

            var numbersList = new List<int>();

            do
            {
                Console.WriteLine("Enter number: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    // exit
                    break;
                }

                numbersList.Add(int.Parse(input));
            }
            while (true);

            var currentLonestSequenceElements = 0;
            var currentLonestSequenceMax = 0;
            var currentLonestSequenceFirstIndex = 0;
            var currentLonestSequenceLastIndex = 0;

            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] == numbersList[i + 1])
                {
                    currentLonestSequenceElements += 1;
                    currentLonestSequenceLastIndex = i + 1;

                    if (currentLonestSequenceElements > currentLonestSequenceMax)
                    {
                        currentLonestSequenceMax = currentLonestSequenceElements;
                        currentLonestSequenceFirstIndex = currentLonestSequenceLastIndex - currentLonestSequenceMax;
                    }
                }
                else
                {                    
                    currentLonestSequenceElements = 0;
                }                
            }

            var listResult = new List<int>();

            for (int i = currentLonestSequenceFirstIndex; i <= currentLonestSequenceLastIndex; i++)
            {
                listResult.Add(numbersList[i]);
            }

            Console.WriteLine("Result = ");
            listResult.ForEach(Console.WriteLine);
        }
    }
}
