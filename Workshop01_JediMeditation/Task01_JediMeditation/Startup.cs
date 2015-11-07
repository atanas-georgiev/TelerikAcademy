namespace Task01_JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var data = Console.ReadLine().Split(' ');
            var masters = new HashSet<string>();
            var knights = new HashSet<string>();
            var padawans = new HashSet<string>();

            foreach (var d in data)
            {
                if (d.StartsWith("m"))
                {
                    masters.Add(d);
                }
                else if (d.StartsWith("k"))
                {
                    knights.Add(d);
                }
                else if (d.StartsWith("p"))
                {
                    padawans.Add(d);
                }
            }

            Console.WriteLine(string.Join(" ", masters) + " " + string.Join(" ", knights) + " " + string.Join(" ", padawans));
        }
    }
}
