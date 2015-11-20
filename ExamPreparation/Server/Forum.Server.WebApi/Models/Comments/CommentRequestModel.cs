namespace Forum.Server.WebApi.Models.Comments
{
    using System;
    using AutoMapper;
    using Forum.Data.Models;
    using Forum.Server.WebApi.Infrastructure.Mappings;

    public class CommentRequestModel : IMapFrom<Comment>
    {
        public string Content { get; set; }

    }
}