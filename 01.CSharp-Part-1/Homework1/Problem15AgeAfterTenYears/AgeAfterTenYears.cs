// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now 
// and how old you will be after 10 years.

using System;

namespace Problem15AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        public static int GetYears(TimeSpan timespan)
        {
            return (int)((double)timespan.Days / 365.2425);
        }
        public static int GetMonths(TimeSpan timespan)
        {
            return (int)((double)timespan.Days / 30.436875);
        }
        static void Main()
        {
            DateTime dateTimeInput, dateTimeAgeNow;

            Console.WriteLine("Enter your birthday");

            try
            {
                // Read birthday date
                dateTimeInput = DateTime.Parse(Console.ReadLine()).Date;
                dateTimeAgeNow = DateTime.Now;

                TimeSpan span = dateTimeAgeNow - dateTimeInput;
                DateTime age = DateTime.MinValue + span;

                Console.WriteLine("Now you are {0} Years and {1} Months old ", age.Year - 1, age.Month - 1);
                Console.WriteLine("After 10 years you will be {0} Years and {1} Months old ", age.Year + 9, age.Month - 1);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input date");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Date not entered");
            }
        }
    }
}
