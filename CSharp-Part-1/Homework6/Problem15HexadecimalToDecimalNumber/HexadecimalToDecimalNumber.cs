//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

namespace Problem15HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter hex number: ");
            string str = Console.ReadLine();
            long result = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                switch (str[str.Length - i - 1].ToString())
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
                        result += long.Parse(str[str.Length - i - 1].ToString()) * (long)Math.Pow(16, i);
                        break;
                    case "A":
                    case "a":
                        result += 10 * (long)Math.Pow(16, i);
                        break;
                    case "B":
                    case "b":
                        result += 11 * (long)Math.Pow(16, i);
                        break;
                    case "C":
                    case "c":
                        result += 12 * (long)Math.Pow(16, i);
                        break;
                    case "D":
                    case "d":
                        result += 13 * (long)Math.Pow(16, i);
                        break;
                    case "E":
                    case "e":
                        result += 14 * (long)Math.Pow(16, i);
                        break;
                    case "F":
                    case "f":
                        result += 15 * (long)Math.Pow(16, i);
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
