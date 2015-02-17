//Problem 17. Date in Bulgarian

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) 
// along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Text;

namespace Problem17DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Console.WriteLine("Enter date in format [day.month.year hour:minute:second]: ");
            string input = Console.ReadLine();

            string[] date = input.Split(new char[] { ' ', '.', ':' });            
            DateTime dt;

            try
            {
                dt = new DateTime(
                    int.Parse(date[2]),  // year
                    int.Parse(date[1]),  // month
                    int.Parse(date[0]),  // day
                    int.Parse(date[3]),  // hour
                    int.Parse(date[4]),  // minute
                    int.Parse(date[5])); // second                
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid date!");
                return;
            }

            dt = dt.AddHours(6).AddMinutes(30);

            var culture = new CultureInfo("bg-BG");

            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(dt.ToString(culture));
            Console.WriteLine(culture.DateTimeFormat.GetDayName(dt.DayOfWeek));
        }
    }
}
