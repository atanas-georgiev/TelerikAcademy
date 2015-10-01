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
    using System.Xml.Linq;

    /// <summary>
    ///     The task 9.
    /// </summary>
    internal static class Task10
    {
        /// <summary>
        ///     The xml dir filename.
        /// </summary>
        private const string xmlDirFilename = "xmlStructure.xml";

        /// <summary>
        /// The create subdirectory xml.
        /// </summary>
        /// <param name="dir">
        /// The dir.
        /// </param>
        /// <returns>
        /// The <see cref="XElement"/>.
        /// </returns>
        private static XElement CreateSubdirectoryXml(DirectoryInfo dir)
        {
            var xmlInfo = new XElement("dir", new XAttribute("name", dir.Name));

            foreach (var file in dir.GetFiles())
            {
                xmlInfo.Add(new XElement("file", new XAttribute("name", file.Name)));
            }

            foreach (var subDir in dir.GetDirectories())
            {
                xmlInfo.Add(CreateSubdirectoryXml(subDir));
            }

            return xmlInfo;
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
            var xmlInfo = new XElement("dirStructure");
            var dir = new DirectoryInfo(directory);

            foreach (var file in dir.GetFiles())
            {
                xmlInfo.Add(new XElement("file", new XAttribute("name", file.Name)));
            }

            foreach (var subDir in dir.GetDirectories())
            {
                xmlInfo.Add(CreateSubdirectoryXml(subDir));
            }

            xmlInfo.Save(xmlDirFilename);
        }
    }
}