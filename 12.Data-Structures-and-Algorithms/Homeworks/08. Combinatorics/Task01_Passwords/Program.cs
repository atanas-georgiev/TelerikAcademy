namespace Task01_Passwords
{
    using System;
    using System.Linq;

    public class Program
    {
        private const int K = 2;

        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray().Count(x => x == '*');
            double result = Math.Pow(K, input);
            Console.WriteLine(result);
        }
    }
}
