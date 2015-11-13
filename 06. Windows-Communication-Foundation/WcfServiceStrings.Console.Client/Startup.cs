namespace WcfServiceStrings.Console.Client
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {            
            var client = new StringServiceClient();

            Console.WriteLine("Enter origianl string");
            var originalString = Console.ReadLine();
            Console.WriteLine("Enter search pattern");
            var pattern = Console.ReadLine();

            var result = client.GetSubStringCount(originalString, pattern);
            Console.WriteLine("Pattern {0} can be found {1} times.", pattern, result);            
        }
    }
}
