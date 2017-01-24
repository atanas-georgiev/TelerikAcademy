namespace Task03_Media_System_Console_Test.Models
{
    using System;
    using System.Text;

    [Serializable]
    public class ArtistApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: " + this.Id + Environment.NewLine);
            sb.Append("Name: " + this.Name + Environment.NewLine);
            sb.Append("Country: " + this.Country + Environment.NewLine);
            sb.Append("DateOfBirth: " + this.DateOfBirth + Environment.NewLine);
            sb.Append("-------------------------------------" + Environment.NewLine);
            return sb.ToString();
        }
    }
}
