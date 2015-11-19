namespace Forum.Server.WebApi.Models.Articles
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using AutoMapper;

    using Forum.Data.Models;
    using Forum.Server.WebApi.Infrastructure.Mappings;

    public class ArticleRequestModel : IMapFrom<Article>, IHaveCustomMappings
    {
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Category { get; set; }

        public string[] Tags { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Article, ArticleRequestModel>()
                .ForMember(a => a.Category, opts => opts.MapFrom(a => a.Category.Name))
                .ForMember(a => a.Tags, opts => opts.MapFrom(a => a.Tags.Select(x => x.Name)));
        }
    }
}
