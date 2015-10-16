// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpRequest.cs" company="">
//   
// </copyright>
// <summary>
//   The http request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Http
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Exceptions;

    /// <summary>
    ///     The http request.
    /// </summary>
    public class HttpRequest : IHttpRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequest"/> class.
        /// </summary>
        /// <param name="stringRequest">
        /// The string request.
        /// </param>
        /// <exception cref="ParserException">
        /// </exception>
        public HttpRequest(string stringRequest)
        {
            var textReader = new StringReader(stringRequest);

            var commands = textReader.ReadLine().Split(' ');

            if (commands.Length != 3)
            {
                throw new ParserException(
                    "Invalid format for the first request line. Expected format: [Method] [Uri] HTTP/[Version]");
            }

            this.Method = commands[0];
            this.Uri = commands[1];
            this.ProtocolVersion = Version.Parse(commands[2].ToLower().Replace("HTTP/".ToLower(), string.Empty));
            this.Headers = new SortedDictionary<string, ICollection<string>>();

            string line;
            while ((line = textReader.ReadLine()) != null)
            {
                this.AddHeader(line);
            }

            this.Action = new ActionDescriptor(this.Uri);
        }

        /// <summary>
        ///     Gets or sets the protocol version.
        /// </summary>
        public Version ProtocolVersion { get; protected set; }

        /// <summary>
        ///     Gets or sets the headers.
        /// </summary>
        public IDictionary<string, ICollection<string>> Headers { get; protected set; }

        /// <summary>
        ///     Gets the uri.
        /// </summary>
        public string Uri { get; }

        /// <summary>
        ///     Gets the method.
        /// </summary>
        public string Method { get; }

        /// <summary>
        ///     Gets the action.
        /// </summary>
        public ActionDescriptor Action { get; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} {1} {2}{3}", this.Method, this.Action, "HTTP/", this.ProtocolVersion));
            var headerStringBuilder = new StringBuilder();
            foreach (var key in this.Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
            }

            sb.AppendLine(headerStringBuilder.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// The add header.
        /// </summary>
        /// <param name="headerLine">
        /// The header line.
        /// </param>
        private void AddHeader(string headerLine)
        {
            var splitHeader = headerLine.Split(new[] { ':' }, 2);
            var headerName = splitHeader[0].Trim();
            var headerValue = splitHeader.Length == 2 ? splitHeader[1].Trim() : string.Empty;

            if (!this.Headers.ContainsKey(headerName))
            {
                this.Headers.Add(headerName, new HashSet<string>(new List<string>()));
            }

            this.Headers[headerName].Add(headerValue);
        }
    }
}