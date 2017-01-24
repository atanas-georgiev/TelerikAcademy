//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;

namespace Problem21LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            int size = ('z' - 'a') + 1;

            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }

            input = input.ToLower();

            foreach (char ch in input)
            {
                if (Char.IsLetter(ch))
                {
                    arr[ch - 'a']++;
                }                
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine("Letter '{0}' -> {1} time(s)", (char)(i + 'a'), arr[i]);
                }
            }
        }
    }
}
