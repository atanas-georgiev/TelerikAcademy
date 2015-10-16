// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedirectActionResult.cs" company="">
//   
// </copyright>
// <summary>
//   The redirect action result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The redirect action result.
    /// </summary>
    public class RedirectActionResult : IActionResult
    {
        /// <summary>
        ///     The model.
        /// </summary>
        private readonly object model;

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectActionResult"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public RedirectActionResult(IHttpRequest request, object model)
        {
            this.model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        /// <summary>
        ///     Gets the request.
        /// </summary>
        public IHttpRequest Request { get; }

        /// <summary>
        ///     Gets the response headers.
        /// </summary>
        public List<KeyValuePair<string, string>> ResponseHeaders { get; }

        /// <summary>
        ///     The get response.
        /// </summary>
        /// <returns>
        ///     The <see cref="HttpResponse" />.
        /// </returns>
        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(this.Request.ProtocolVersion, HttpStatusCode.Redirect, string.Empty);
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}