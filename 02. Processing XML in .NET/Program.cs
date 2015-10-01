using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLProcessing
{
    using System.Xml;

    class Program
    {
        private const string FileName = "catalog.xml";
        static void Main(string[] args)
        {

            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash-table.

            var doc = new XmlDocument();
            doc.Load(FileName);
            var rootNode = doc.DocumentElement;
            Console.WriteLine(rootNode.OuterXml);
        }
    }
}
