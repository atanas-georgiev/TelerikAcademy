// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task4.cs" company="">
//   
// </copyright>
// <summary>
//   The task 4.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Xml;

    /// <summary>
    ///     The task 4.
    /// </summary>
    internal static class Task4
    {
        /// <summary>
        ///     The delete price.
        /// </summary>
        private const int DeletePrice = 20;

        /// <summary>
        /// The delete all albums with price more than 20.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void DeleteAllAlbumsWithPriceMoreThan20(string xmlFile)
        {
            // Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.
            var doc = new XmlDocument();
            doc.Load(xmlFile);

            var rootNode = doc.DocumentElement;

            if (rootNode != null)
            {
                foreach (XmlNode album in rootNode.ChildNodes)
                {
                    var price = decimal.Parse(album.ChildNodes[4].InnerText);

                    if (price > DeletePrice)
                    {
                        Console.WriteLine("Album {0} deleted!", album.FirstChild.InnerText);
                        album.ParentNode.RemoveChild(album);
                    }
                }
            }

            doc.Save(xmlFile);
        }
    }
}