// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task8.cs" company="">
//   
// </copyright>
// <summary>
//   The task 8.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    /// <summary>
    ///     The task 8.
    /// </summary>
    public static class Task8
    {
        /// <summary>
        ///     The write file name.
        /// </summary>
        private const string writeFileName = "album.xml";

        /// <summary>
        /// The create album xml.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void CreateAlbumXml(string xmlFile)
        {
            // Write a program, which(using XmlReader and XmlWriter) reads the file catalog.xml and creates 
            // the file album.xml, in which stores in appropriate way the names of all albums and their authors.
            var artists = new List<string>();
            var albums = new List<string>();

            using (var reader = XmlReader.Create(xmlFile))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "name")
                        {
                            albums.Add(reader.ReadElementString());
                        }
                        else if (reader.Name == "artist")
                        {
                            artists.Add(reader.ReadElementString());
                        }
                    }
                }
            }

            using (var writer = new XmlTextWriter(writeFileName, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                for (var i = 0; i < albums.Count; i++)
                {
                    writer.WriteStartElement("album");
                    writer.WriteElementString("title", albums[i]);
                    writer.WriteElementString("artist", artists[i]);
                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
            }
        }
    }
}