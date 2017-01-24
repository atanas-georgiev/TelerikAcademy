namespace WcfServiceStrings.Library
{
    using System;

    public class StringService : IStringService
    {
        public int GetSubStringCount(string originalString, string subString)
        {
            var count = 0;
            var i = 0;
            while ((i = originalString.IndexOf(subString, i, StringComparison.Ordinal)) != -1)
            {
                i += subString.Length;
                count++;
            }

            return count;
        }      
    }
}
