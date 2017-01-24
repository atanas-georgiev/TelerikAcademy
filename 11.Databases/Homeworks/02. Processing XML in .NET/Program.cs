// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMLProcessing
{
    using XMLProcessing.Tasks;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The file name.
        /// </summary>
        private const string FileName = "catalog.xml";

        /// <summary>
        ///     The xsl name.
        /// </summary>
        private const string XslName = "catalog.xslt";

        /// <summary>
        ///     The txt name.
        /// </summary>
        private const string TxtName = "person.txt";

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Task2.ExtractArtists(FileName);
            Task3.ExtractArtistsXPath(FileName);
            Task4.DeleteAllAlbumsWithPriceMoreThan20(FileName);
            Task5.ExtractAllSongTitles(FileName);
            Task6.ExtractAllSongTitlesXpathLinq(FileName);
            Task7.CreateXmlFromTxtFile(TxtName);
            Task8.CreateAlbumXml(FileName);
            Task9.TraverseDirectory("../..");
            Task10.TraverseDirectory("../..");
            Task11.ExtractAlbumPrices(FileName);
            Task12.ExtractAlbumPricesLinq(FileName);
            Task14.ConvertXmlToXsl(FileName, XslName);
            Task16.GenerateXsdFile(FileName);
        }
    }
}