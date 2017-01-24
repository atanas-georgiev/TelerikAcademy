// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task16.cs" company="">
//   
// </copyright>
// <summary>
//   The task 16.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    /// <summary>
    ///     The task 16.
    /// </summary>
    public static class Task16
    {
        /// <summary>
        /// The generate xsd file.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        public static void GenerateXsdFile(string xmlFile)
        {
            // Using Visual Studio generate an XSD schema for the file catalog.xml.
            // Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against the schema.
            // Test it with valid XML catalogs and invalid XML catalogs.
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "catalog.xsd");

            var doc = XDocument.Load(xmlFile);
            var invalidDoc = XDocument.Load("catalog_invalid.xml");

            doc.Validate(schema, (sender, args) => { Console.WriteLine("* {0} * {1}", "catalog.xml", args.Message); });

            invalidDoc.Validate(
                schema, 
                (sender, args) => { Console.WriteLine("* {0} * {1}", "catalog_invalid.xml", args.Message); });
        }
    }
}