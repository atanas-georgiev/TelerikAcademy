//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

namespace Problem16DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            DateTime dt1, dt2;

            string[] dates = { "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy", "d.M.yyyy" };

            Console.WriteLine("Enter first date: ");
            if (false == DateTime.TryParseExact(Console.ReadLine(), dates, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt1))
            {
                Console.WriteLine("Invalid date entered!");
                return;
            }

            Console.WriteLine("Enter second date: ");
            if (false == DateTime.TryParseExact(Console.ReadLine(), dates, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt2))
            {
                Console.WriteLine("Invalid date entered!");
                return;
            }

            Console.WriteLine("Difference: " + (dt1 - dt2).Days + " days");
        }
    }
}
