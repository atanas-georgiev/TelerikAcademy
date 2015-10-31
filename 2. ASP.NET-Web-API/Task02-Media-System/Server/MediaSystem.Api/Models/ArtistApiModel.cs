namespace MediaSystem.Api.Models
{
    using System;

    using MediaSystem.Models;

    public class ArtistApiModel
    {
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
