namespace SimpleHttpClient
{
    using System;
    using System.Net.Http;

    using Newtonsoft.Json;

    using Task03_Media_System_Console_Test.Controllers;
    using Task03_Media_System_Console_Test.Models;

    public class Program
    {
        private const string ServerAddress = "http://localhost:6443/api/";

        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ServerAddress);

            // Artists with JSON
            var artist = new ArtistApiModel() { Name = "Pesho123", Country = "Bulgaria", DateOfBirth = DateTime.Now };
            Console.WriteLine("Adding following artist " + artist);
            Console.WriteLine("-----------------------------------");
            Artist.Add(httpClient, artist);
            Console.ReadLine();
            Console.WriteLine("Listing all artists");
            Console.WriteLine("-----------------------------------");
            Artist.Print(httpClient);
            Console.ReadLine();
            var updatedArtist = new ArtistApiModel() { Name = "PeshoUpdated", Country = "Zimbabve", DateOfBirth = DateTime.Now };
            Console.WriteLine("Update artist with ID 1 to " + updatedArtist);
            Console.WriteLine("-----------------------------------");            
            Artist.Update(httpClient, 1, artist);
            Console.ReadLine();
            Console.WriteLine("Delete artist with ID 1");
            Console.WriteLine("-----------------------------------");
            Artist.Delete(httpClient, 1);
            Console.ReadLine();

            // Songs with XML
            var song = new SongApiModel() { Title = "Nothing else matters", Genre = "Blues", Year = 1995, ArtistId = 1};
            Song.Add(httpClient, song);
            Console.ReadLine();

            Console.WriteLine("-----------------------------------");
            Song.Print(httpClient);
            Console.ReadLine();
        }
    }
}