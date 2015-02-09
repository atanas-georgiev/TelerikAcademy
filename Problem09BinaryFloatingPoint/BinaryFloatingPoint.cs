//Problem 9.* Binary floating-point

//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//Example:
//number	sign	exponent	mantissa
//-27,25	1	    10000011	10110100000000000000000

using System;
using System.Collections;

namespace Problem09BinaryFloatingPoint
{
    class BinaryFloatingPoint
    {
        static string ConvertFloatToIeee754BinaryString(float input)
        {
            const int fractionSize = 23;

            float value;
            int sign;
            long exponent;
            int lead;
            int[] fraction;

            value = input;

            sign = 1;
            lead = 0;
            exponent = 0;
            fraction = new int[fractionSize];

            int i;
            for (i = 0; i < fractionSize; i++)
            {
                fraction[i] = 0;
            }

            // of course, working on the sign first
            if (value == 0.0f)
            {
                sign = 1;
            }
            else if (value == -0.0f)
            {
                sign = -1;
                value = -1.0f * value;
            }
            else if (value < 0.0f)
            {
                sign = -1;
                value = -1.0f * value;
            }

            if (value > 0.0f)
            {
                // now, the exponent part
                while (value >= 2.0f)
                {
                    exponent++;
                    value = value / 2.0f;
                }
                while (value < 1.0f && exponent > -127)
                {
                    exponent--;
                    value = value * 2.0f;
                }

                // the implict leading bit
                if (value >= 1.0f)
                {
                    value = value - 1.0f;
                    value = value * 2.0f;
                    lead = 1;
                }
                else
                {
                    lead = 0;
                }

                // fraction part
                for (i = 0; i < fractionSize; i++)
                {
                    if (value >= 1.0f)
                    {
                        fraction[i] = 1;
                        value = value - 1.0f;
                    }
                    else
                    {
                        fraction[i] = 0;
                    }
                    value = value * 2.0f;
                }
            }

            // Convert result to string binary
            string str = string.Empty;
            string strExponent = string.Empty;

            // Add sign
            if (sign < 0)
            {
                str = str + "1";
            }
            else
            {
                str = str + "0";
            }

            strExponent = Convert.ToString(exponent - 1, 2);
            strExponent = strExponent.PadLeft(7, '0');

            // Add lead bit
            str += lead;

            // Add exponent
            str += strExponent;

            // Add fraction
            for (i = 0; i < fractionSize; i++)
            {
                str = str + fraction[i];
            }           

            // Return result
            return str;
        }
        static void Main()
        {
            Console.WriteLine("Enter float value");
            float value = float.Parse(Console.ReadLine());
            Console.WriteLine("Float value {0} has IEEE 754 representation '{1}' ", value, ConvertFloatToIeee754BinaryString(value));
        }
    }
}
