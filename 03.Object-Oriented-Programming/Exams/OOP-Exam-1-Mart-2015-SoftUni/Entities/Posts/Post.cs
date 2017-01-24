namespace ConsoleForum.Entities.Users
{
    using System;
    using System.Collections.Generic;
    using ConsoleForum.Contracts;

    public class Post : IPost
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public IUser Author { get; set; }
    }
}
