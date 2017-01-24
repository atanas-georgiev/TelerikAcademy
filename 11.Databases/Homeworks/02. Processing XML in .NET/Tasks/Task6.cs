// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task6.cs" company="">
//   
// </copyright>
// <summary>
//   The task 6.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    ///     The task 6.
    /// </summary>
    public static class Task6
    {
        /// <summary>
        /// The extract all song titles xpath linq.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void ExtractAllSongTitlesXpathLinq(string xmlFile)
        {
            // Write a program, which using XmlReader extracts all song titles from catalog.xml.
            // use XDocument and LINQ query.
            var doc = XDocument.Load(xmlFile);

            var songs = from song in doc.Descendants("songs").Descendants().Descendants("title") select song.Value;

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}