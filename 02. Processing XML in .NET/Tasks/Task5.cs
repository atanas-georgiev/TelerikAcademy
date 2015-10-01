// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task5.cs" company="">
//   
// </copyright>
// <summary>
//   The task 5.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /// <summary>
    ///     The task 5.
    /// </summary>
    public static class Task5
    {
        /// <summary>
        /// The extract all song titles.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractAllSongTitles(string xmlFile)
        {
            // Write a program, which using XmlReader extracts all song titles from catalog.xml.
            var doc = new XmlDocument();
            doc.Load(xmlFile);

            var songs = new List<string>();

            var rootNode = doc.DocumentElement;

            if (rootNode != null)
            {
                foreach (XmlNode album in rootNode.ChildNodes)
                {
                    foreach (XmlNode song in album.ChildNodes[5])
                    {
                        songs.Add(song.FirstChild.InnerText);
                    }
                }
            }

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}