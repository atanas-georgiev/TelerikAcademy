//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

namespace Problem12IndexOfLetters
{
    class IndexOfLetters
    {
        // create an array with alphabet length
        static char[] array = new char['Z' - 'A' + 1];
        static int BinarySearch(char ch)
        {
            int start = 0;
            int end = array.Length - 1;
            int mid = 0;

            // Binary search
            while (start <= end)
            {
                mid = (start + end) / 2;

                if (array[mid] < ch)
                {
                    start = mid + 1;
                    continue;
                }

                if (array[mid] > ch)
                {
                    end = mid - 1;
                    continue;
                }

                if (array[mid] == ch)
                {
                    // Value found
                    return mid;
                }
            }

            return 0;
        }
        static void Main()
        {

            // Fill in the new array with letters
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar('A' + i);
            }

            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine().ToUpper();

            foreach (char ch in word)
            {
                Console.WriteLine("Letter {0} has index {1}", ch, BinarySearch(ch));
            }

        }
    }
}
