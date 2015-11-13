namespace WcfServiceWeekDays.Library
{
    using System;

    public class ServiceWeekDays : IServiceWeekDays
    {
        public string GetDayOfWeekInBulgarian(DateTime dateTime)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return dayOfWeek;
        }
    }
}
