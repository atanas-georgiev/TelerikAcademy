//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

namespace Problem16DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            long num = long.Parse(Console.ReadLine());
            string result = "";
            string temp;

            while (num > 0)
            {
                temp = (num % 16).ToString();

                switch (temp)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        result += temp;
                        break;
                    case "10":
                        result += "A";
                        break;
                    case "11":
                        result += "B";
                        break;
                    case "12":
                        result += "C";
                        break;
                    case "13":
                        result += "D";
                        break;
                    case "14":
                        result += "E";
                        break;
                    case "15":
                        result += "F";
                        break;
                    default:
                        break;
                }

                num = num / 16;
            }

            // Reverse result
            result = Reverse(result);

            Console.WriteLine("Result: " + result);
        }
    }
}
