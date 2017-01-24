// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonActionResultWithoutCaching.cs" company="">
//   
// </copyright>
// <summary>
//   The json action result without caching.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System;
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The json action result without caching.
    /// </summary>
    public class JsonActionResultWithoutCaching : JsonActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionResultWithoutCaching"/> class.
        /// </summary>
        /// <param name="r">
        /// The r.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        public JsonActionResultWithoutCaching(HttpRequest r, object model)
            : base(r, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
            throw new Exception();
        }
    }
}