// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task11.cs" company="">
//   
// </copyright>
// <summary>
//   The task 11.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Xml;

    /// <summary>
    ///     The task 11.
    /// </summary>
    public static class Task11
    {
        /// <summary>
        /// The extract album prices.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractAlbumPrices(string xmlFile)
        {
            // Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            // Use XPath query.
            var doc = new XmlDocument();
            doc.Load(xmlFile);
            var fiveYearsAgo = DateTime.Now.Year - 5;
            var xPathQuery = "descendant::album[year > " + fiveYearsAgo + "]";
            var artistList = doc.SelectNodes(xPathQuery);

            if (artistList != null)
            {
                foreach (XmlNode artistNode in artistList)
                {
                    Console.WriteLine(artistNode.ChildNodes[4].InnerText);
                }
            }
        }
    }
}