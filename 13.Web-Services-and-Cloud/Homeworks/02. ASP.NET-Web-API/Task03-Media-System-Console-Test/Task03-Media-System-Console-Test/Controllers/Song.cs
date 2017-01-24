namespace Task03_Media_System_Console_Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Xml.Serialization;

    using Newtonsoft.Json;

    using Task03_Media_System_Console_Test.Models;

    public static class Song
    {
        public static async void Print(HttpClient httpClient)
        {
            var response = await httpClient.GetAsync("song");
            response.Headers.Add("Accept", "text/xml");
            var resultDataText = await response.Content.ReadAsStringAsync();
        }

        public static async void Add(HttpClient httpClient, SongApiModel song)
        {
            var response = await httpClient.PostAsXmlAsync("song", song);
            Console.WriteLine("Done!");
        }

        public static async void Update(HttpClient httpClient, int id, ArtistApiModel artist)
        {
            HttpContent putContent = new StringContent(JsonConvert.SerializeObject(artist));
            putContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpClient.PutAsync("artist/" + id, putContent);

            try
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Artist updated!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error creating artist");
            }
        }

        public static async void Delete(HttpClient httpClient, int id)
        {
            var response = await httpClient.DeleteAsync("artist/" + id);

            try
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Artist deleted!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error deleting artist");
            }
        }
    }
}
