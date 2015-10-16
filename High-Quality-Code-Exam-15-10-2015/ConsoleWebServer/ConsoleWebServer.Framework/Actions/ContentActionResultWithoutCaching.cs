// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentActionResultWithoutCaching.cs" company="">
//   
// </copyright>
// <summary>
//   The content action result without caching.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The content action result without caching.
    /// </summary>
    public class ContentActionResultWithoutCaching : ContentActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentActionResultWithoutCaching"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public ContentActionResultWithoutCaching(IHttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}