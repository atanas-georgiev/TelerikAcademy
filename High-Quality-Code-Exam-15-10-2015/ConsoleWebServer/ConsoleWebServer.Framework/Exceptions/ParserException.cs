// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParserException.cs" company="">
//   
// </copyright>
// <summary>
//   The parser exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Exceptions
{
    using System;

    using ConsoleWebServer.Framework.Actions;

    /// <summary>
    ///     The parser exception.
    /// </summary>
    public class ParserException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        public ParserException(string message, ActionDescriptor request = null)
            : base(message)
        {
        }
    }
}