// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="">
//   
// </copyright>
// <summary>
//   The link.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace JSON_Homework
{
    using Newtonsoft.Json;

    /// <summary>
    /// The link.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the rel.
        /// </summary>
        [JsonProperty("@rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}