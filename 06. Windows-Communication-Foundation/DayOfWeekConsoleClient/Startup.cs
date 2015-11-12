namespace DayOfWeekConsoleClient
{
    using System;
    using System.Text;

    using DayOfWeekServiceReference;

    public class Startup
    {
        public static void Main()
        {
            var client = new DayOfWeekServiceClient();
            var result = client.GetDayOfWeekInBulgarian(DateTime.Now);
            Console.WriteLine(result);
        }
    }
}
