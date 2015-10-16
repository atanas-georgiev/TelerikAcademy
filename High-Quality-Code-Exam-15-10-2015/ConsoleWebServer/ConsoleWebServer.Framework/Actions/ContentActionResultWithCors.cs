// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentActionResultWithCors.cs" company="">
//   
// </copyright>
// <summary>
//   The content action result with cors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    /// The content action result with cors.
    /// </summary>
    /// <typeparam name="TResult">
    /// </typeparam>
    public class ContentActionResultWithCors<TResult> : ContentActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentActionResultWithCors{TResult}"/> class.
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
        public ContentActionResultWithCors(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
        }
    }
}