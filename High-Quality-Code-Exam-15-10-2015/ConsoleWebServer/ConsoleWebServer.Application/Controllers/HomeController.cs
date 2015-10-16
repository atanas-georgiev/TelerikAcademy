// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="">
//   
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        ///     The no cache message.
        /// </summary>
        private const string NoCacheAndCorsMessage = "Live page with no caching and CORS";

        /// <summary>
        /// The no cache message.
        /// </summary>
        private const string NoCacheMessage = "Live page with no caching";

        /// <summary>
        ///     The home page message.
        /// </summary>
        private const string HomePageMessage = "Home page :)";

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        public HomeController(IHttpRequest request)
            : base(request)
        {
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="param">
        /// The param.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Index(string param)
        {
            return this.Content(HomePageMessage);
        }

        /// <summary>
        /// The live page.
        /// </summary>
        /// <param name="param">
        /// The param.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult LivePage(string param)
        {
            return new ContentActionResultWithoutCaching(this.Request, NoCacheMessage);
        }

        /// <summary>
        /// The live page for ajax.
        /// </summary>
        /// <param name="param">
        /// The param.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult LivePageForAjax(string param)
        {
            return new ContentActionResultWithCorsWithoutCaching(this.Request, NoCacheAndCorsMessage, "*");
        }

        /// <summary>
        /// The forum.
        /// </summary>
        /// <param name="param">
        /// The param.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Forum(string param)
        {
            return new RedirectActionResultWithCors(this.Request, @"https://telerikacademy.com/Forum/Home");
        }
    }
}