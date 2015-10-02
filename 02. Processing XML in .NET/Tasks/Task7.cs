// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task7.cs" company="">
//   
// </copyright>
// <summary>
//   The task 7.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System.IO;
    using System.Text;
    using System.Xml;

    /// <summary>
    ///     The task 7.
    /// </summary>
    internal class Task7
    {
        /// <summary>
        ///     The write file name.
        /// </summary>
        private const string writeFileName = "person.xml";

        /// <summary>
        /// The create xml from txt file.
        /// </summary>
        /// <param name="txtFile">
        /// The txt file.
        /// </param>
        public static void CreateXmlFromTxtFile(string txtFile)
        {
            // In a text file we are given the name, address and phone number of given person (each at a single line).
            // Write a program, which creates new XML document, which contains these data in structured XML format.
            using (var reader = new StreamReader(txtFile))
            {
                using (var writer = new XmlTextWriter(writeFileName, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("data");

                    writer.WriteStartElement("person");
                    writer.WriteElementString("name", reader.ReadLine());
                    writer.WriteElementString("address", reader.ReadLine());
                    writer.WriteElementString("gsm", reader.ReadLine());
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                }
            }
        }
    }
}