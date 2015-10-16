// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IActionResult.cs" company="">
//   
// </copyright>
// <summary>
//   The ActionResult interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The ActionResult interface. Used to get the response from the server.
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        ///     HttpResponse response returned after performed action
        /// </summary>
        /// <returns>
        ///     The <see cref="HttpResponse" />.
        /// </returns>
        HttpResponse GetResponse();
    }
}