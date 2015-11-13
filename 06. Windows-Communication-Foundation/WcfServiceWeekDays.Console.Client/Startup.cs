namespace WcfServiceWeekDays.Console.Client
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var weekDaysClient = new ServiceReferenceWeekDays.ServiceWeekDaysClient();
            var result = weekDaysClient.GetDayOfWeekInBulgarian(DateTime.Now);
            Console.WriteLine("Today is: " + result);
        }
    }
}
