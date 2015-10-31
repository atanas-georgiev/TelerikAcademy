namespace MediaSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using MediaSystem.Api.Models;
    using MediaSystem.Data;
    using MediaSystem.Models;
    using MediaSystem.Services.Data;
    using MediaSystem.Services.Data.Interfaces;

    using StudentSystem.Data;

    public class ArtistController : ApiController
    {
        private readonly IArtistService artistService;

        public ArtistController() : 
            this(new ArtistService(new EfGenericRepository<Artist>(new MediaSystemContext())))
        {
            
        }
        public ArtistController(IArtistService artistService)
        {
            this.artistService = artistService;
        }

        public IHttpActionResult Get()
        {
            var result = this.artistService
                .GetAll()
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.artistService.GetById(id);

            return this.Ok(result);
        }

        public IHttpActionResult Post(ArtistApiModel artist)
        {
            this.artistService.Add(artist.Name, artist.DateOfBirth, artist.Country);

            return this.Ok();
        }
    }
}
