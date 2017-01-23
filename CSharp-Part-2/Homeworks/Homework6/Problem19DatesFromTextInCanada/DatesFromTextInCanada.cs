//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Problem19DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static public string[] ExtractDates(string str)
        {
            string RegexPattern = @"\b\d{2}.\d{2}.\d{4}\b";

            // Find matches
            MatchCollection matches = Regex.Matches(str, RegexPattern, RegexOptions.IgnoreCase);

            string[] MatchList = new string[matches.Count];

            // add each match
            int c = 0;
            foreach (Match match in matches)
            {
                MatchList[c] = match.ToString();
                c++;
            }
            return MatchList;
        }
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string[] dates = ExtractDates(Console.ReadLine());
            CultureInfo ci = new CultureInfo("en-CA");

            foreach (string date in dates)
            {
                DateTime dt;

                DateTime.TryParseExact(date, "dd.mm.yyyy", CultureInfo.CreateSpecificCulture(ci.Name), DateTimeStyles.None, out dt);
                Console.WriteLine(dt.ToString(ci));
            }
        }
    }
}
