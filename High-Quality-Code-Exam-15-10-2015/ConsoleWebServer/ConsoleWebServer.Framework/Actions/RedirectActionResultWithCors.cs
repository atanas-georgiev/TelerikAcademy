// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedirectActionResultWithCors.cs" company="">
//   
// </copyright>
// <summary>
//   The redirect action result with cors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The redirect action result with cors.
    /// </summary>
    public class RedirectActionResultWithCors : RedirectActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectActionResultWithCors"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public RedirectActionResultWithCors(IHttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Location", model.ToString()));
        }
    }
}