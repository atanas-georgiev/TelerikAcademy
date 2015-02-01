using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            input = input.TrimStart('0');
            input = input.Insert(0, input[input.Length - 1].ToString());
            input = input.Remove(input.Length - 1);
            input = input.TrimStart('0');
            input = input.Insert(0, input[input.Length - 1].ToString());
            input = input.Remove(input.Length - 1);
            input = input.TrimStart('0');
            input = input.Insert(0, input[input.Length - 1].ToString());
            input = input.Remove(input.Length - 1);
            input = input.TrimStart('0');

            Console.WriteLine(input);
        }
    }
}
