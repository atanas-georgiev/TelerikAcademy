// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Video.cs" company="">
//   
// </copyright>
// <summary>
//   The video.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace JSON_Homework
{
    using Newtonsoft.Json;

    /// <summary>
    /// The video.
    /// </summary>
    internal class Video
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        [JsonProperty("link")]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("yt:videoId")]
        public string Id { get; set; }
    }
}