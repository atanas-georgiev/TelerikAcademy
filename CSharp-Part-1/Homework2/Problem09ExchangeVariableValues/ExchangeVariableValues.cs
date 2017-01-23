// Problem 9. Exchange Variable Values
// Declare two integer variables  a  and  b  and assign them with  5  and  10  
// and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.

using System;

namespace Problem09ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a, b, tempVar;
            a = 5;
            b = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            tempVar = a;
            a = b;
            b = tempVar;
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
