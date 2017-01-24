// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHttpRequest.cs" company="">
//   
// </copyright>
// <summary>
//   The HttpRequest interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoleWebServer.Framework.Http
{
    using System;
    using System.Collections.Generic;

    using ConsoleWebServer.Framework.Actions;

    /// <summary>
    /// The HttpRequest interface.
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// Gets the action.
        /// </summary>
        ActionDescriptor Action { get; }

        /// <summary>
        /// Gets the headers.
        /// </summary>
        IDictionary<string, ICollection<string>> Headers { get; }

        /// <summary>
        /// Gets the method.
        /// </summary>
        string Method { get; }

        /// <summary>
        /// Gets the protocol version.
        /// </summary>
        Version ProtocolVersion { get; }

        /// <summary>
        /// Gets the uri.
        /// </summary>
        string Uri { get; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToString();
    }
}