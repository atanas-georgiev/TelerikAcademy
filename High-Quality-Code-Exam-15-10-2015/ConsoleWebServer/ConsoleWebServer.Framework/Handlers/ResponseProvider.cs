// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResponseProvider.cs" company="">
//   
// </copyright>
// <summary>
//   The response provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Handlers
{
    using System;
    using System.Net;

    using ConsoleWebServer.Framework.Http;
    using ConsoleWebServer.Framework.Methods;

    /// <summary>
    ///     The response provider.
    /// </summary>
    public class ResponseProvider : IResponseProvider
    {
        /// <summary>
        /// The get response.
        /// </summary>
        /// <param name="requestAsString">
        /// The request as string.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponse"/>.
        /// </returns>
        public HttpResponse GetResponse(string requestAsString)
        {
            HttpResponse response = null;

            try
            {
                // response = this.Process(new HttpRequest(requestAsString));
                Requester headOptions = new RequesterOptions();
                Requester reqOptions = new RequesterOptions();
                Requester reqFile = new RequesterFile();
                Requester reqController = new RequesterController();
                headOptions.SetSuccessor(reqOptions);
                reqOptions.SetSuccessor(reqFile);
                reqFile.SetSuccessor(reqController);
                response = headOptions.ProcessRequest(new HttpRequest(requestAsString));
            }
            catch (Exception ex)
            {
                response = new HttpResponse(new Version(1, 1), HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
        }
    }
}