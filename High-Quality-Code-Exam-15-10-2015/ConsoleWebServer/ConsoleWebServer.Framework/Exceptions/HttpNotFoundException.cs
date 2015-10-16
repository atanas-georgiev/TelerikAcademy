// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpNotFoundException.cs" company="">
//   
// </copyright>
// <summary>
//   The http not found exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Exceptions
{
    using System;

    /// <summary>
    ///     The http not found exception.
    /// </summary>
    public class HttpNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpNotFoundException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public HttpNotFoundException(string message)
            : base(message)
        {
        }
    }
}