//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace Problem25ExtractTextFromHtml
{
    class ExtractTextFromHtml
    {
        static void Main()
        {
            // input data from html.txt file
            var inputHtml = new StreamReader(@"..\..\Html.txt");
            Console.SetIn(inputHtml);
            string input = Console.ReadLine();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(input);

            XmlNode node = doc.DocumentElement.SelectSingleNode("/html/head/title");
            Console.WriteLine("Title: " + node.InnerText);
            node = doc.DocumentElement.SelectSingleNode("/html/body");
            Console.WriteLine("Body: " + node.InnerText);
        }
    }
}
