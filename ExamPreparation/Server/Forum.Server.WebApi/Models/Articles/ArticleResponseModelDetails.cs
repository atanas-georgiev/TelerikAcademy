using Forum.Server.WebApi.Models.Comments;

namespace Forum.Server.WebApi.Models.Articles
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Forum.Data.Models;

    public class ArticleResponseModelDetails : ArticleResponseModel
    {
        public IEnumerable<CommentResponseModel> Comments { get; set; }
        public IEnumerable<string> Likes { get; set; }

        public override void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Article, ArticleResponseModelDetails>()
                .ForMember(a => a.Category, opts => opts.MapFrom(a => a.Category.Name))
                .ForMember(a => a.DateCreated, opts => opts.MapFrom(a => a.DateTime))
                .ForMember(a => a.Comments, opts => opts.MapFrom(a => a.Comments))
                .ForMember(a => a.Likes, opts => opts.MapFrom(a => a.Likes.Select(x => x.User.Email)))
                .ForMember(a => a.Tags, opts => opts.MapFrom(a => a.Tags.Select(x => x.Name)));
        }
    }
}