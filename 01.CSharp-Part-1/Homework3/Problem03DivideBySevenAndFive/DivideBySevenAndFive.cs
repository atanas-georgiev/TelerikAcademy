//Problem 3. Divide by 7 and 5 
// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.

using System;

namespace Problem03DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            Int32 number;

            Console.WriteLine("Enter number:");

            try
            {
                number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Divided by 7 and 5? {0}",
                    (((number % 5 == 0) && (number % 7 == 0)) ? "True" : "False"));
            }
            catch (FormatException)
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
