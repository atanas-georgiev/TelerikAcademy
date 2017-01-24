// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequesterFile.cs" company="">
//   
// </copyright>
// <summary>
//   The requester file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Methods
{
    using System;
    using System.IO;
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The requester file.
    /// </summary>
    internal class RequesterFile : Requester
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
            if (request.Uri.LastIndexOf(".", StringComparison.Ordinal)
                > request.Uri.LastIndexOf("/", StringComparison.Ordinal))
            {
                var filePath = Environment.CurrentDirectory + "/" + request.Uri;

                if (!File.Exists(filePath))
                {
                    return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, "File not found!");
                }

                var fileContents = File.ReadAllText(filePath);
                var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
                return response;
            }

            return this.Successor.ProcessRequest(request);
        }
    }
}