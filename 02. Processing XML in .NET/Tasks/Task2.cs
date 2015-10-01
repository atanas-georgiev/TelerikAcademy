// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task2.cs" company="">
//   
// </copyright>
// <summary>
//   The task 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Collections;
    using System.Xml;

    /// <summary>
    ///     The task 2.
    /// </summary>
    public static class Task2
    {
        /// <summary>
        /// The extract artists.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractArtists(string xmlFile)
        {
            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash-table.
            var doc = new XmlDocument();
            doc.Load(xmlFile);

            var artists = new Hashtable();

            var rootNode = doc.DocumentElement;

            if (rootNode != null)
            {
                foreach (XmlNode album in rootNode.ChildNodes)
                {
                    var artist = album.ChildNodes[1].InnerText;

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