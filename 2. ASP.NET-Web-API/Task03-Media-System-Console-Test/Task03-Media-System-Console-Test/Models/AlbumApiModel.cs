namespace Task03_Media_System_Console_Test.Models
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class AlbumApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int? Year { get; set; }

        public string Producer { get; set; }

        public ICollection<int> ArtistsIds;

        public ICollection<int> SongsIds;
    }
}
