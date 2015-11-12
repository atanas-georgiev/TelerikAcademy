namespace DayOfWeek
{
    using System;

    public class DayOfWeekService : IDayOfWeekService
    {
        public string GetDayOfWeekInBulgarian(DateTime dateTime)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return dayOfWeek;
        }
    }
}
