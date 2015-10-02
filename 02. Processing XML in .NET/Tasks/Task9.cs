// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task9.cs" company="">
//   
// </copyright>
// <summary>
//   The task 9.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System.IO;
    using System.Text;
    using System.Xml;

    /// <summary>
    ///     The task 9.
    /// </summary>
    internal class Task9
    {
        /// <summary>
        ///     The xml dir filename.
        /// </summary>
        private const string xmlDirFilename = "xmlStructure.xml";

        /// <summary>
        ///     The writer.
        /// </summary>
        private static XmlTextWriter writer;

        /// <summary>
        /// The create subdirectory xml.
        /// </summary>
        /// <param name="dir">
        /// The dir.
        /// </param>
        private static void CreateSubdirectoryXml(DirectoryInfo dir)
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", dir.Name);

            foreach (var file in dir.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }

            foreach (var subDir in dir.GetDirectories())
            {
                CreateSubdirectoryXml(subDir);
            }

            writer.WriteEndElement();
        }

        /// <summary>
        /// The traverse directory.
        /// </summary>
        /// <param name="directory">
        /// The directory.
        /// </param>
        public static void TraverseDirectory(string directory)
        {
            // Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            var dir = new DirectoryInfo(directory);

            using (writer = new XmlTextWriter(xmlDirFilename, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("dirStructure");

                foreach (var file in dir.GetFiles())
                {
                    writer.WriteStartElement("file");
                    writer.WriteAttributeString("name", file.Name);
                    writer.WriteEndElement();
                }

                foreach (var subDir in dir.GetDirectories())
                {
                    CreateSubdirectoryXml(subDir);
                }

                writer.WriteEndDocument();
            }
        }
    }
}