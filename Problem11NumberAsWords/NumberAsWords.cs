//Problem 11.* Number as Words
//• Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//Examples:

//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

using System;

namespace Problem11NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in range [0..999] -> ");
            int number = int.Parse(Console.ReadLine());

            if ((number < 0) || (number > 999))
            {
                Console.WriteLine("Invalid number!");
                Console.ReadLine();
                return;
            }
            else
            {
                int majorDigit  = ((number / 100) % 10);
                int middleDigit = ((number / 10) % 10);
                int minorDigit  = (number % 10);
                string numStr = "";

                switch (majorDigit)
                {
                    case 1:
                        numStr = "one hundred ";
                        break;
                    case 2:
                        numStr = "two hundred ";
                        break;
                    case 3:
                        numStr = "three hundred ";
                        break;
                    case 4:
                        numStr = "four hundred ";
                        break;
                    case 5:
                        numStr = "five hundred ";
                        break;
                    case 6:
                        numStr = "six hundred ";
                        break;
                    case 7:
                        numStr = "seven hundred ";
                        break;
                    case 8:
                        numStr = "eight hundred ";
                        break;
                    case 9:
                        numStr = "nine hundred ";
                        break;
                    default:
                        break;                   
                }

                if ((majorDigit != 0) && ((middleDigit != 0) || (minorDigit != 0)))
                {
                    numStr += "and ";
                }

                switch (middleDigit)
                {
                    case 2:
                        numStr += "twenty ";
                        break;
                    case 3:
                        numStr += "thirty ";
                        break;
                    case 4:
                        numStr += "fourty ";
                        break;
                    case 5:
                        numStr += "fifty ";
                        break;
                    case 6:
                        numStr += "sixty ";
                        break;
                    case 7:
                        numStr += "seventy ";
                        break;
                    case 8:
                        numStr += "eighty ";
                        break;
                    case 9:
                        numStr += "ninety ";
                        break;
                    default:
                        break;
                }

                if (middleDigit != 1)
                {
                    switch (minorDigit)
                    {
                        case 1:
                            numStr += "one";
                            break;
                        case 2:
                            numStr += "two";
                            break;
                        case 3:
                            numStr += "three";
                            break;
                        case 4:
                            numStr += "four";
                            break;
                        case 5:
                            numStr += "five";
                            break;
                        case 6:
                            numStr += "six";
                            break;
                        case 7:
                            numStr += "seven";
                            break;
                        case 8:
                            numStr += "eight";
                            break;
                        case 9:
                            numStr += "nine";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (minorDigit)
                    {
                        case 0:
                            numStr += "ten";
                            break;
                        case 1:
                            numStr += "evelen";
                            break;
                        case 2:
                            numStr += "twelve";
                            break;
                        case 3:
                            numStr += "thirteen";
                            break;
                        case 4:
                            numStr += "fourteen";
                            break;
                        case 5:
                            numStr += "fifteen";
                            break;
                        case 6:
                            numStr += "sixteen";
                            break;
                        case 7:
                            numStr += "seventeen";
                            break;
                        case 8:
                            numStr += "eighteen";
                            break;
                        case 9:
                            numStr += "nineteen";
                            break;
                        default:
                            break;
                    }
                }

                if (number == 0)
                {
                    numStr = "zero";
                }

                Console.WriteLine("Number as words is: " + numStr);                
            }
        }
    }
}
