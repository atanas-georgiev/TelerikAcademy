//Problem 6. Four-Digit Number 
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following: ◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
//Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
//Puts the last digit in the first position:  dabc  (in our example  1201 ).
//Exchanges the second and the third digits:  acbd  (in our example  2101 ).

using System;

namespace Problem06FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            UInt16 number;
            Byte[] digits = new Byte[4];

            Console.Write("Enter 4 digit number: ");

            try
            {
                number = UInt16.Parse(Console.ReadLine());
                if ((number < 1000) || (number > 9999))
                {
                    // Number do not have exactly 4 digits or starts with 0
                    Console.WriteLine("Input value should be 4 digit!");
                }
                else
                {
                    digits[0] = (Byte)(number % 10);
                    digits[1] = (Byte)((number / 10) % 10);
                    digits[2] = (Byte)((number / 100) % 10);
                    digits[3] = (Byte)((number / 1000) % 10);

                    Console.WriteLine("Sum of all digits: {0}", digits[0] + digits[1] + digits[2] + digits[3]);
                    Console.WriteLine("Number is reserve order {0}{1}{2}{3}", digits[0], digits[1], digits[2], digits[3]);
                    Console.WriteLine("Last digit in the first position: {0}{3}{2}{1}", digits[0], digits[1], digits[2], digits[3]);               
                    Console.WriteLine("Second and third digits exchanged {3}{1}{2}{0}", digits[0], digits[1], digits[2], digits[3]);
                }
            }
            catch
            {
                // Wrong format is entered. Handle exception
                Console.WriteLine("Format of entered data is not correct");
            }
        }
    }
}
