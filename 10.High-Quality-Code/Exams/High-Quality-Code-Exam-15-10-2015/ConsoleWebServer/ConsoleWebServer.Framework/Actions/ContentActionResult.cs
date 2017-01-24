﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentActionResult.cs" company="">
//   
// </copyright>
// <summary>
//   The content action result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The content action result.
    /// </summary>
    public class ContentActionResult : IActionResult
    {
        /// <summary>
        ///     The model.
        /// </summary>
        private readonly object model;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentActionResult"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public ContentActionResult(IHttpRequest request, object model)
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
            var response = new HttpResponse(
                this.Request.ProtocolVersion, 
                HttpStatusCode.OK, 
                this.model.ToString(), 
                "text/plain; charset=utf-8");
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}