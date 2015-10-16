// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IResponseProvider.cs" company="">
//   
// </copyright>
// <summary>
//   The ResponseProvider interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Handlers
{
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The ResponseProvider interface. Used for providing the response back to the user.
    /// </summary>
    public interface IResponseProvider
    {
        /// <summary>
        /// Get the response from the server.
        /// </summary>
        /// <param name="requestAsString">
        /// The command request as string.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponse"/>.
        /// </returns>
        HttpResponse GetResponse(string requestAsString);
    }
}