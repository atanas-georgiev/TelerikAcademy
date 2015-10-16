// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequesterHead.cs" company="">
//   
// </copyright>
// <summary>
//   The requester head.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Methods
{
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The requester head.
    /// </summary>
    internal class RequesterHead : Requester
    {
        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponse"/>.
        /// </returns>
        public override HttpResponse ProcessRequest(HttpRequest request)
        {
            if (request.Method.ToLower() == "head")
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Empty);
            }

            return this.Successor.ProcessRequest(request);
        }
    }
}