using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    /// <summary>
    /// Problem 1. StringBuilder.Substring
    /// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
    /// </summary>
    static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder str, int startIndex, int len)
        {
            string s = str.ToString();
            s = s.Substring(startIndex, len);
            return new StringBuilder(s);
        }
    }
}
