
//Problem 8. Digit as Word
// • Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). ◦ Print  “not a digit”  in case of invalid input.
//◦ Use a switch statement.

using System;

namespace Problem08DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.Write("Enter digit [0..9]: ");
            string digit = Console.ReadLine();
            string digitText;

            switch (digit)
            {
                case "0":
                    digitText = "Zero";
                    break;
                case "1":
                    digitText = "One";
                    break;
                case "2":
                    digitText = "Two";
                    break;
                case "3":
                    digitText = "Three";
                    break;
                case "4":
                    digitText = "Four";
                    break;
                case "5":
                    digitText = "Five";
                    break;
                case "6":
                    digitText = "Six";
                    break;
                case "7":
                    digitText = "Seven";
                    break;
                case "8":
                    digitText = "Eight";
                    break;
                case "9":
                    digitText = "Nine";
                    break;
                default:
                    digitText = "No a digit!";
                    break;
            }
            Console.WriteLine(digitText);
        }
    }
}
