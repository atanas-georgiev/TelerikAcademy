// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task14.cs" company="">
//   
// </copyright>
// <summary>
//   The task 14.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing.Tasks
{
    using System;
    using System.Xml.Xsl;

    /// <summary>
    ///     The task 14.
    /// </summary>
    public static class Task14
    {
        /// <summary>
        ///     The html string.
        /// </summary>
        private const string HtmlString = "catalog.html";

        /// <summary>
        /// The convert xml to xsl.
        /// </summary>
        /// <param name="xmlFile">
        /// The xml file.
        /// </param>
        /// <param name="xslFile">
        /// The xsl file.
        /// </param>
        public static void ConvertXmlToXsl(string xmlFile, string xslFile)
        {
            // Write a C# program to apply the XSLT stylesheet transformation 
            // on the file catalog.xml using the class XslTransform.
            var xslt = new XslCompiledTransform();
            xslt.Load(xslFile);
            xslt.Transform(xmlFile, HtmlString);

            Console.WriteLine(xmlFile + " converted to " + HtmlString);
        }
    }
}