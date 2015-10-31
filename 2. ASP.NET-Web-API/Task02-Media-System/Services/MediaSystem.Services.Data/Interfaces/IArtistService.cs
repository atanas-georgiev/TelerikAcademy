﻿namespace MediaSystem.Services.Data.Interfaces
{
    using System;
    using System.Linq;

    using MediaSystem.Models;

    public interface IArtistService
    {
        IQueryable<Artist> GetAll();

        Artist GetById(int id);

        void Add(string name, DateTime dateOfBirth, Country country = null);

        void Update(Artist newArtistData);

        void DeleteById(Artist artist);
    }
}
