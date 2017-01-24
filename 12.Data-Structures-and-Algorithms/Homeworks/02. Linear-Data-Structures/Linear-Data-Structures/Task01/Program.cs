namespace Task01
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        // Write a program that reads from the console a sequence of positive integer numbers.
        // The sequence ends when empty line is entered.
        // Calculate and print the sum and average of the elements of the sequence.
        // Keep the sequence in List<int>.

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

            // find sum of all numbers
            var sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                sum += numbersList[i];
            }

            // print result
            Console.WriteLine("Sum of the numbers is {0}", sum);
            Console.WriteLine("Avg of the numbers is {0}", sum / numbersList.Count);
        }
    }
}
