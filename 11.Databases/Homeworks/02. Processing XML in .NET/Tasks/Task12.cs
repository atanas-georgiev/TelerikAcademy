// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task12.cs" company="">
//   
// </copyright>
// <summary>
//   The task 12.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    ///     The task 12.
    /// </summary>
    public static class Task12
    {
        /// <summary>
        /// The extract album prices linq.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractAlbumPricesLinq(string xmlFile)
        {
            // Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            // Use LINQ.
            var doc = XDocument.Load(xmlFile);
            var fiveYearsAgo = DateTime.Now.Year - 5;

            var prices = from album in doc.Descendants("album")
                         where int.Parse(album.Element("year").Value) > fiveYearsAgo
                         select album.Element("price").Value;

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}