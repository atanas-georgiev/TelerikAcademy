namespace SocialNetwork.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using SocialNetwork.ConsoleClient.Searcher;
    using SocialNetwork.Data;
    using SocialNetwork.Models;

    public class Startup
    {
        public static void Main()
        {
            // prepare table
            var db = new SocialNetworkContext();
            db.Database.Delete();
            db.Database.Create();

            //// task 6 - parsing data from xml
            var parser = new XmlParser(db);
            parser.ParseFriendShipData();
            parser.ParsePostData();

            // task 7 - linq requests to database implemented in MySearcher class
            MySearcher searcher = new MySearcher(db);
            DataSearcher.Search(searcher);            
        }
    }
}
