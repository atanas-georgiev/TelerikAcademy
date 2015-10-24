using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.ConsoleClient.Searcher
{
    using System.Collections;

    using SocialNetwork.Data;

    class MySearcher : ISocialNetworkService
    {
        private SocialNetworkContext db;

        public MySearcher(SocialNetworkContext db)
        {
            this.db = db;
        }

        public IEnumerable GetUsersAfterCertainDate(int year)
        {
            var query = from user in db.Users
                        where user.RegistrationDate.Year >= year
                        select new {
                            Username = user.Username,
                            FirstName = user.FirstName,
                            LastName = user.Lastname,
                            Images = user.Images.Count
                        };

            return query.ToList();
        }

        public IEnumerable GetPostsByUser(string username)
        {
            var query = from post in db.Posts
                        where post.Users.Any(x => x.Username == username)
                        select new
                        {
                            PostedOn = post.DateTime,
                            Content = post.Content,
                            Users = post.Users
                        };

            return query.ToList();
        }

        public IEnumerable GetFriendships(int page = 1, int pageSize = 25)
        {
            var query = from f in db.Friendships
                        where f.ApprovedDate != null
                        orderby f.ApprovedDate
                        select
                            new
                                {
                                    FirstUserName = f.FirstUser.Username,
                                    FirstUserImage = f.FirstUser.Images,
                                    SecondUserName = f.SecondUser.Username,
                                    SecondUserImage = f.SecondUser.Images,
                                };
            return query.ToList();
        }

        public IEnumerable GetChatUsers(string username)
        {
            var query = from u in db.Users
                        join m in db.Messages
                        on u.UserId equals m.AuthorId
                        where m.Friendship.SecondUser.Username == username
                        orderby u.Username                        
                        select
                            new
                            {
                                u.Username
                            };
            return query.ToList();
        }
    }
}
