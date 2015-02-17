//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.

using System;
using System.Text.RegularExpressions;

namespace Problem18ExtractEmails
{
    class ExtractEmails
    {
        static public string[] ExtractMails(string str)
        {
            string RegexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

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
            string[] emails = ExtractMails(Console.ReadLine());

            foreach (string mail in emails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
