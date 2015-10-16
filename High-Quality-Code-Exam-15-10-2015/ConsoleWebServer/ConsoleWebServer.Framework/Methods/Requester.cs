// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Requester.cs" company="">
//   
// </copyright>
// <summary>
//   The requester.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Methods
{
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The requester.
    /// </summary>
    internal abstract class Requester
    {
        /// <summary>
        ///     Gets or sets the successor.
        /// </summary>
        protected Requester Successor { get; set; }

        /// <summary>
        /// The set successor.
        /// </summary>
        /// <param name="successor">
        /// The successor.
        /// </param>
        public void SetSuccessor(Requester successor)
        {
            this.Successor = successor;
        }

        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponse"/>.
        /// </returns>
        public abstract HttpResponse ProcessRequest(HttpRequest request);
    }
}