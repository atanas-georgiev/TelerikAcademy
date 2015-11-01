namespace MediaSystem.Services.Data.Interfaces
{
    using System;
    using System.Linq;

    using MediaSystem.Models;

    public interface ISongService
    {
        IQueryable<Song> GetAll();

        Song GetById(int id);

        void Add(string title, int artistId, string genre = null, int? year = null);

        bool Update(int id, int artistId, string title = null, string genre = null, int? year = null);

        bool DeleteById(int id);
    }
}
