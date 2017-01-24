using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.ConsoleClient
{
    using System.Data.Entity;
    using System.Xml.Linq;

    using SocialNetwork.Data;
    using SocialNetwork.Models;

    class XmlParser
    {
        private XDocument xMLDocFriendships;
        private XDocument xMLDocPosts;
        private HashSet<User> users;

        private int cnt;

        private SocialNetworkContext db;

        public XmlParser(SocialNetworkContext db)
        {
            this.xMLDocFriendships = XDocument.Load("XmlFiles/Friendships.xml");
            this.xMLDocPosts = XDocument.Load("XmlFiles/Posts.xml");
            this.users = new HashSet<User>();
            this.db = db;
        }

        public void ParseFriendShipData()
        {
            Console.Write("Parsing friendships and adding to database:" );
            // Get all elements
            var friendships = xMLDocFriendships.Root.Elements("Friendship").ToList();

            cnt = 0;

            foreach (XElement friendship in friendships)
            {
                // prepare object to write
                var friendshipToAdd = new Friendship();

                // get friendship date
                if (friendship.Attributes().First().Value == "true")
                {
                    friendshipToAdd.ApprovedDate = DateTime.Parse(friendship.Elements("FriendsSince").First().Value);
                }
                else
                {
                    friendshipToAdd.ApprovedDate = null;
                }

                // create first user to write
                var firstUser = new User();

                firstUser.Username = friendship.Element("FirstUser").Element("Username").Value;
                try
                {
                    firstUser.FirstName = friendship.Element("FirstUser").Element("FirstName").Value;
                }
                catch (NullReferenceException)
                {
                    // no nothing if element do not exist
                }

                try
                {
                    firstUser.Lastname = friendship.Element("FirstUser").Element("Lastname").Value;
                }
                catch (NullReferenceException)
                {
                    // no nothing if element do not exist
                }

                // get registration date for first user
                firstUser.RegistrationDate = DateTime.Parse(friendship.Element("FirstUser").Element("RegisteredOn").Value);

                //foreach (XElement image in friendship.Element("FirstUser").Element("Images").Elements("Image"))
                //{
                //    user.Images.Add(new Image()
                //                        {
                //                            Url = image.Element("ImageUrl").Value,
                //                            Extension = image.Element("FileExtension").Value
                //                        });
                //}

                var firstUserFromList = users.FirstOrDefault(x => x.Username == firstUser.Username);

                if (firstUserFromList == null)
                {
                    friendshipToAdd.FirstUser = firstUser;
                    users.Add(firstUser);
                }
                else
                {
                    friendshipToAdd.FirstUser = firstUserFromList;
                }

                // get second user
                var secondUser = new User();

                secondUser.Username = friendship.Element("SecondUser").Element("Username").Value;
                try
                {
                    secondUser.FirstName = friendship.Element("SecondUser").Element("FirstName").Value;
                }
                catch (NullReferenceException)
                {
                    // no nothing if element do not exist
                }

                try
                {
                    secondUser.Lastname = friendship.Element("SecondUser").Element("Lastname").Value;
                }
                catch (NullReferenceException)
                {
                    // no nothing if element do not exist
                }

                secondUser.RegistrationDate = DateTime.Parse(friendship.Element("SecondUser").Element("RegisteredOn").Value);

                //foreach (XElement image in friendship.Element("SecondUser").Element("Images").Elements("Image"))
                //{
                //    user2.Images.Add(new Image()
                //    {
                //        Url = image.Element("ImageUrl").Value,
                //        Extension = image.Element("FileExtension").Value
                //    });
                //}

                var secondUserFromList = users.FirstOrDefault(x => x.Username == secondUser.Username);

                if (secondUserFromList == null)
                {
                    friendshipToAdd.SecondUser = secondUser;
                    users.Add(secondUser);
                }
                else
                {
                    friendshipToAdd.SecondUser = secondUserFromList;
                }

                db.Friendships.Add(friendshipToAdd);
                db.SaveChanges();
                Console.Write(".");
            }

            db.Dispose();
            db = new SocialNetworkContext();
            
        }

        public void ParsePostData()
        {
            Console.Write("Parsing Posts and adding to database:");
            var posts = xMLDocPosts.Root.Elements("Post");
            var usersFromDb = db.Users.ToList<User>();

            foreach (XElement post in posts)
            {
                var postToAdd = new Post();
                postToAdd.Content = post.Element("Content").Value;
                postToAdd.DateTime = DateTime.Parse(post.Element("PostedOn").Value);

                var usersInPost = post.Element("Users").Value.Split(',');

                foreach (var userToAdd in usersInPost)
                {
                    postToAdd.Users.Add(usersFromDb.FirstOrDefault(x => x.Username == userToAdd));
                }

                db.Posts.Add(postToAdd);

                if (cnt % 100 == 0)
                {
                    db.SaveChanges();
                    db.Dispose();
                    db = new SocialNetworkContext();
                    usersFromDb = db.Users.ToList<User>();
                    Console.Write(".");
                }
                cnt++;
            }
        }
    }
}

