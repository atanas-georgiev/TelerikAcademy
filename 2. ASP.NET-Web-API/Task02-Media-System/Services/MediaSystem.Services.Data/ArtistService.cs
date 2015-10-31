namespace MediaSystem.Services.Data
{
    using System;
    using System.Linq;

    using Models;
    using Interfaces;

    using StudentSystem.Data;

    public class ArtistService : IArtistService
    {
        private readonly IRepository<Artist> artists;

        public ArtistService(IRepository<Artist> artists)
        {
            this.artists = artists;
        }
        public IQueryable<Artist> GetAll()
        {
            return this.artists.All();
        }

        public Artist GetById(int id)
        {
            return this.artists.GetById(id);
        }

        public void Add(string name, DateTime dateOfBirth, Country country = null)
        {
            this.artists.Add(new Artist() { Name = name, DateOfBirth = dateOfBirth, Country = country});
            this.artists.SaveChanges();

        }

        public void Update(Artist newArtistData)
        {
            this.artists.Update(newArtistData);
            this.artists.SaveChanges();
        }

        public void DeleteById(Artist artist)
        {
            this.artists.Delete(artist);
            this.artists.SaveChanges();
        }
    }
}
