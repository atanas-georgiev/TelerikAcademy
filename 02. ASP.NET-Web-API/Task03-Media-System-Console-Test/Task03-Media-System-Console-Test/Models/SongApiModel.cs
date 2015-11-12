namespace Task03_Media_System_Console_Test.Models
{
    using System;

    [Serializable]
    public class SongApiModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int? Year { get; set; }
        
        public int? ArtistId { get; set; }
    }
}
