// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace JSON_Homework
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The remote file.
        /// </summary>
        private const string RemoteFile = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";

        /// <summary>
        /// The local file.
        /// </summary>
        private const string LocalFile = "data.xml";

        /// <summary>
        /// The html file.
        /// </summary>
        private const string HtmlFile = "videos.html";

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            // get rss data to xml file
            var client = new WebClient();
            client.DownloadFile(RemoteFile, LocalFile);

            // read the received data
            var xmlDoc = XDocument.Load(LocalFile);

            // converto to json format
            var jsonString = JsonConvert.SerializeXNode(xmlDoc.Root);

            // get video titles with LINQ and print them in the console
            var jsonObj = JObject.Parse(jsonString);

            var videos = from t in jsonObj["feed"]["entry"].Children()["media:group"]
                         select new { title = t["media:title"], url = t["media:content"]["@url"] };

            foreach (var title in videos)
            {
                Console.WriteLine(title.title);
            }

            // all videos to POCO
            var videosJson =
                jsonObj["feed"]["entry"].Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            // create result HTML file
            var sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html><html><head><title>Videos</title></head><body>");
            sb.Append(@"</body></html>");

            foreach (var video in videosJson)
            {
                sb.Append(@"<h3>" + video.Title + "</h3>");
                sb.Append(@"<iframe width='420' height='315' src='");
                sb.Append(video.Link.Href + "'</iframe>");
            }

            File.WriteAllText(HtmlFile, sb.ToString());
        }
    }
}