// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Controller.cs" company="">
//   
// </copyright>
// <summary>
//   The controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The controller.
    /// </summary>
    public abstract class Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Controller"/> class.
        /// </summary>
        /// <param name="r">
        /// The r.
        /// </param>
        protected Controller(IHttpRequest r)
        {
            this.Request = r;
        }

        /// <summary>
        ///     Gets the request.
        /// </summary>
        public IHttpRequest Request { get; }

        /// <summary>
        /// The content.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        protected IActionResult Content(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        /// <summary>
        /// The json.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        protected IActionResult Json(object model)
        {
            return new JsonActionResult(this.Request, model);
        }

        /// <summary>
        /// The redirect.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        protected IActionResult Redirect(object model)
        {
            return new RedirectActionResult(this.Request, model);
        }
    }
}