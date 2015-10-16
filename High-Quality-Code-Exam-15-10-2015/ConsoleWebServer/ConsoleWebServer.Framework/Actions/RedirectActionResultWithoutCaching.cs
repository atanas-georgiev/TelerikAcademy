// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedirectActionResultWithoutCaching.cs" company="">
//   
// </copyright>
// <summary>
//   The redirect action result without caching.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The redirect action result without caching.
    /// </summary>
    public class RedirectActionResultWithoutCaching : RedirectActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectActionResultWithoutCaching"/> class.
        /// </summary>
        /// <param name="r">
        /// The r.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public RedirectActionResultWithoutCaching(HttpRequest r, object model)
            : base(r, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}