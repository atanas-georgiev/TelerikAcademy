// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonActionResultWithCorsWithoutCaching.cs" company="">
//   
// </copyright>
// <summary>
//   The json action result with cors without caching.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The json action result with cors without caching.
    /// </summary>
    public class JsonActionResultWithCorsWithoutCaching : JsonActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionResultWithCorsWithoutCaching"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <param name="corsSettings">
        /// The cors settings.
        /// </param>
        public JsonActionResultWithCorsWithoutCaching(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}