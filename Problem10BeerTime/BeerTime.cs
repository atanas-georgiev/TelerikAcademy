//Problem 10.* Beer Time
//• A beer time is after  1:00 PM  and before  3:00 AM .
//• Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints  beer time  or  non-beer time  according to the definition above or  invalid time  if the time cannot be parsed. Note: You may need to learn how to parse dates and times. 

using System;

namespace Problem10BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter time in format: hh:mm tt -> ");
                DateTime time = DateTime.Parse(Console.ReadLine());
                time.ToString("hh:mm tt");
                DateTime timeStart = DateTime.Parse("1:00 PM");
                DateTime timeEnd = DateTime.Parse("3:00 AM");

                if (time >= timeStart || time < timeEnd)
                {
                    Console.WriteLine("Beer time!");
                }
                else
                {
                    Console.WriteLine("Non-beer time!");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid time entered!");
                Main();
            }
        }
    }
}
