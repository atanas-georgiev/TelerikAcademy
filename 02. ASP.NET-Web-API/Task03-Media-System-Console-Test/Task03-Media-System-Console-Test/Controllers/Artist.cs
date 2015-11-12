namespace Task03_Media_System_Console_Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    using Newtonsoft.Json;

    using Task03_Media_System_Console_Test.Models;

    public static class Artist
    {
        public static async void Print(HttpClient httpClient)
        {
            var response = await httpClient.GetAsync("artist");
            var resultDataText = await response.Content.ReadAsStringAsync();
            var resultDataPoco = JsonConvert.DeserializeObject<List<ArtistApiModel>>(resultDataText);
            resultDataPoco.ForEach(Console.WriteLine);
        }

        public static async void Add(HttpClient httpClient, ArtistApiModel artist)
        {
            HttpContent postContent = new StringContent(JsonConvert.SerializeObject(artist));
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync("artist", postContent);

            try
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Artist created!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error creating artist");
            }
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
