// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonActionResultWithCors.cs" company="">
//   
// </copyright>
// <summary>
//   The json action result with cors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The json action result with cors.
    /// </summary>
    public class JsonActionResultWithCors : JsonActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionResultWithCors"/> class.
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
        public JsonActionResultWithCors(IHttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
        }
    }
}