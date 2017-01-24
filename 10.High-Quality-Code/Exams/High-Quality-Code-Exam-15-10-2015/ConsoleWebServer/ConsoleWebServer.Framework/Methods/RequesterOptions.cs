// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequesterOptions.cs" company="">
//   
// </copyright>
// <summary>
//   The requester options.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Methods
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;

    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The requester options.
    /// </summary>
    internal class RequesterOptions : Requester
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
            if (request.Method.ToLower() == "options")
            {
                var routes =
                    Assembly.GetEntryAssembly()
                        .GetTypes()
                        .Where(x => x.Name.EndsWith("Controller") && typeof(Controller).IsAssignableFrom(x))
                        .Select(
                            x =>
                            new
                                {
                                    x.Name, Methods = x.GetMethods().Where(m => m.ReturnType == typeof(IActionResult))
                                })
                        .SelectMany(
                            x =>
                            x.Methods.Select(
                                m =>
                                string.Format(
                                    "/{0}/{1}/{{parameter}}", 
                                    x.Name.Replace("Controller", string.Empty), 
                                    m.Name)))
                        .ToList();

                return new HttpResponse(
                    request.ProtocolVersion, 
                    HttpStatusCode.OK, 
                    string.Join(Environment.NewLine, routes));
            }

            return this.Successor.ProcessRequest(request);
        }
    }
}