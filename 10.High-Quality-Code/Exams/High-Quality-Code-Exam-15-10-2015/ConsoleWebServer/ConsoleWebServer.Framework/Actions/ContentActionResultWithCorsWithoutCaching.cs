// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentActionResultWithCorsWithoutCaching.cs" company="">
//   
// </copyright>
// <summary>
//   The content action result with cors without caching.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The content action result with cors without caching.
    /// </summary>
    public class ContentActionResultWithCorsWithoutCaching : ContentActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentActionResultWithCorsWithoutCaching"/> class.
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
        public ContentActionResultWithCorsWithoutCaching(IHttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}