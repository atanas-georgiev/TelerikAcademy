namespace Forum.Server.WebApi.Models.Articles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using AutoMapper;

    using Forum.Data.Models;
    using Forum.Server.WebApi.Infrastructure.Mappings;
    using Forum.Server.WebApi.Models.Tags;

    public class ArticleResponseModel : IMapFrom<Article>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public DateTime DateCreated { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public virtual void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Article, ArticleResponseModel>()
                .ForMember(a => a.Category, opts => opts.MapFrom(a => a.Category.Name))
                .ForMember(a => a.DateCreated, opts => opts.MapFrom(a => a.DateTime))
                .ForMember(a => a.Tags, opts => opts.MapFrom(a => a.Tags.Select(x => x.Name)));
        }
    }
}
