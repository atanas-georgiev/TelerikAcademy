// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task3.cs" company="">
//   
// </copyright>
// <summary>
//   The task 3.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Collections;
    using System.Xml;

    /// <summary>
    ///     The task 3.
    /// </summary>
    public static class Task3
    {
        /// <summary>
        /// The extract artists x path.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractArtistsXPath(string xmlFile)
        {
            // XPath
            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash-table.
            var doc = new XmlDocument();
            doc.Load(xmlFile);

            var xPathQuery = "/catalogue/album/artist";

            var artists = new Hashtable();
            var artistList = doc.SelectNodes(xPathQuery);

            if (artistList != null)
            {
                foreach (XmlNode artistNode in artistList)
                {
                    var artist = artistNode.InnerText;

                    if (!artists.ContainsKey(artist))
                    {
                        artists.Add(artist, 1);
                    }
                    else
                    {
                        var numAlbums = (int)artists[artist];
                        artists[artist] = ++numAlbums;
                    }
                }
            }

            foreach (DictionaryEntry artist in artists)
            {
                Console.WriteLine("Artist {0} has {1} album(s)", artist.Key, artists[artist.Key]);
            }
        }
    }
}