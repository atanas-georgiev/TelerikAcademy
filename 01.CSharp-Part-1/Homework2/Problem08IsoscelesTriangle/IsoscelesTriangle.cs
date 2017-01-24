// Problem 8. Isosceles Triangle
// Write a program that prints an isosceles triangle of 9 copyright symbols  © , something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note: The  ©  symbol may be displayed incorrectly at the console so you may need to change the console character encoding to  UTF-8  and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the  ©  symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;

namespace Problem08IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("   {0}", '\u00A9');
            Console.WriteLine("  {0} {0}", '\u00A9');
            Console.WriteLine(" {0} {0} {0}", '\u00A9');
            Console.WriteLine("{0} {0} {0} {0}", '\u00A9');
        }
    }
}
