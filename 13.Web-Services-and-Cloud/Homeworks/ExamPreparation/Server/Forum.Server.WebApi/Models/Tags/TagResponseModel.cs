namespace Forum.Server.WebApi.Models.Tags
{
    using AutoMapper;

    using Forum.Data.Models;
    using Forum.Server.WebApi.Infrastructure.Mappings;

    public class TagResponseModel : IMapFrom<Tag>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Tag, TagResponseModel>().ForMember(t => t.Name, opts => opts.MapFrom(t => t.Name));
        }
    }
}
