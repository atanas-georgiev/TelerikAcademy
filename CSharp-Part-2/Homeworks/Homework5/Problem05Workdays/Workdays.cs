//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

namespace Problem05Workdays
{
    class Workdays
    {
        static DateTime[] holidays = 
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 10, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };

        static bool IsHoliday(DateTime dt)
        {
            bool res = false;

            foreach (var d in holidays)
            {
                if (dt.Year == d.Year && dt.Month == d.Month && dt.Day == d.Day)
                    return true;
            }
            return res;
        }

        static void Main()
        {
            Console.WriteLine("Enter date: ");
            DateTime endDt;
            DateTime startDt = DateTime.Now;
            double workDays = 0;

            if (DateTime.TryParse(Console.ReadLine(), out endDt))
            {
                if (DateTime.Compare(endDt, startDt) < 0)
                {
                    Console.WriteLine("Enter date should be after today!");
                    return;
                }

                while (startDt.Year != endDt.Year || startDt.Month != endDt.Month || startDt.Day != endDt.Day)
                {
                    if (startDt.DayOfWeek != DayOfWeek.Saturday && startDt.DayOfWeek != DayOfWeek.Sunday && IsHoliday(startDt) == false)
                    {
                        // workdays
                        workDays++;
                    }

                    startDt = startDt.AddDays(1);
                }

                Console.WriteLine("Workdays between today and {0} -> {1}", endDt, workDays);
            }
            else
            {
                Console.WriteLine("Invalid date entered");
            }
        }
    }
}
