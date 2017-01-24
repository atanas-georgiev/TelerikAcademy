// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiController.cs" company="">
//   
// </copyright>
// <summary>
//   The api controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Application.Controllers
{
    using System;
    using System.Linq;

    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The api controller.
    /// </summary>
    public class ApiController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiController"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        public ApiController(IHttpRequest request)
            : base(request)
        {
        }

        /// <summary>
        /// The return me.
        /// </summary>
        /// <param name="param">
        /// The param.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult ReturnMe(string param)
        {
            return this.Json(new { param });
        }

        /// <summary>
        /// The get date with cors.
        /// </summary>
        /// <param name="domainName">
        /// The domain name.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        public IActionResult GetDateWithCors(string domainName)
        {
            var requestReferer = string.Empty;
            if (this.Request.Headers.ContainsKey("Referer"))
            {
                requestReferer = this.Request.Headers["Referer"].FirstOrDefault();
            }

            if (string.IsNullOrWhiteSpace(requestReferer) || !requestReferer.Contains(domainName))
            {
                throw new ArgumentException("Invalid referer!");
            }

            return new JsonActionResultWithCors(
                this.Request, 
                new { date = DateTime.Now.ToString("yyyy-MM-dd"), moreInfo = "Data available for " + domainName }, 
                domainName);
        }
    }
}