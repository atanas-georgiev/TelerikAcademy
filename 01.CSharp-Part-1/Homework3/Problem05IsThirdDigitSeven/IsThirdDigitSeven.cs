//Problem 5. Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is  7 .

using System;

namespace Problem05IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main()
        {
            Int32 number;

            Console.Write("Enter number: ");

            try
            {
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Third digit is 7? : {0}", (number / 100) % 10 == 7);
            }
            catch (FormatException)
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
