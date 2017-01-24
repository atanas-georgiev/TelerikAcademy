// Problem 2. Float or Double?
// Which of the following values can be assigned to a variable of type  float  and which 
// to a variable of type  double :  34.567839023, 12.345, 8923.1234857, 3456.091 ?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.
using System;

namespace Problem02FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double variable1 = 34.567839023d;
            float variable2 = 12.345f;
            double variable3 = 8923.1234857d;
            float variable4 = 3456.091f;
        }
    }
}
