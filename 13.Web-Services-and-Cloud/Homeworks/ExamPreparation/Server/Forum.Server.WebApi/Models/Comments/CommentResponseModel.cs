using System;
using AutoMapper;
using Forum.Data.Models;
using Forum.Server.WebApi.Infrastructure.Mappings;

namespace Forum.Server.WebApi.Models.Comments
{
    public class CommentResponseModel : IMapFrom<Comment>, IHaveCustomMappings
    {

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentResponseModel>()
                .ForMember(a => a.AuthorName, opts => opts.MapFrom(a => a.User.Email));
        }
    }
}