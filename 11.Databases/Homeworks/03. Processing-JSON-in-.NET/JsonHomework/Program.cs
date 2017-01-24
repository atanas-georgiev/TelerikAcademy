using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonHomework
{
    using System.Net;

    class Program
    {
        const string remoteXmlFile = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        const string localXmlFile = "data.xml";
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            webClient.DownloadFile(remoteXmlFile, localXmlFile);
            
        }
    }
}
