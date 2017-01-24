// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonActionResult.cs" company="">
//   
// </copyright>
// <summary>
//   The json action result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System.Collections.Generic;
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    using Newtonsoft.Json;

    /// <summary>
    ///     The json action result.
    /// </summary>
    public class JsonActionResult : IActionResult
    {
        /// <summary>
        ///     The model.
        /// </summary>
        private readonly object model;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionResult"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public JsonActionResult(IHttpRequest request, object model)
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
                this.GetStatusCode(), 
                this.GetContent(), 
                "application / json");
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }

        /// <summary>
        ///     The get status code.
        /// </summary>
        /// <returns>
        ///     The <see cref="HttpStatusCode" />.
        /// </returns>
        public virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        /// <summary>
        ///     The get content.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string GetContent()
        {
            return JsonConvert.SerializeObject(this.model);
        }
    }
}