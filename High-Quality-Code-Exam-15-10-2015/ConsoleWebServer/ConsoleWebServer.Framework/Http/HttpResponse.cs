// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpResponse.cs" company="">
//   
// </copyright>
// <summary>
//   The http response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Http
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Text;

    /// <summary>
    ///     The http response.
    /// </summary>
    public class HttpResponse
    {
        /// <summary>
        ///     The server engine name.
        /// </summary>
        private const string ServerEngineName = "ConsoleWebServer";

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpResponse"/> class.
        /// </summary>
        /// <param name="httpVersion">
        /// The http version.
        /// </param>
        /// <param name="statusCode">
        /// The status code.
        /// </param>
        /// <param name="body">
        /// The body.
        /// </param>
        /// <param name="contentType">
        /// The content type.
        /// </param>
        public HttpResponse(
            Version httpVersion, 
            HttpStatusCode statusCode, 
            string body, 
            string contentType = "text/plain; charset=utf-8")
        {
            this.ProtocolVersion =
                Version.Parse(httpVersion.ToString().ToLower().Replace("HTTP/".ToLower(), string.Empty));
            this.Headers = new SortedDictionary<string, ICollection<string>>();
            this.Body = body;
            this.StatusCode = statusCode;
            this.AddHeader("Server", ServerEngineName);
            this.AddHeader("Content-Length", body.Length.ToString());
            this.AddHeader("Content-Type", contentType);
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
        ///     Gets the status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        ///     Gets the body.
        /// </summary>
        public string Body { get; }

        /// <summary>
        ///     Gets the status code as string.
        /// </summary>
        public string StatusCodeAsString
        {
            get
            {
                return this.StatusCode.ToString();
            }
        }

        /// <summary>
        /// The add header.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public void AddHeader(string name, string value)
        {
            if (!this.Headers.ContainsKey(name))
            {
                this.Headers.Add(name, new HashSet<string>());
            }

            this.Headers[name].Add(value);
        }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(
                string.Format(
                    "{0}{1} {2} {3}", 
                    "HTTP/", 
                    this.ProtocolVersion, 
                    (int)this.StatusCode, 
                    this.StatusCodeAsString));
            var headerStringBuilder = new StringBuilder();
            foreach (var key in this.Headers.Keys)
            {
                headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
            }

            stringBuilder.AppendLine(headerStringBuilder.ToString());
            if (!string.IsNullOrWhiteSpace(this.Body))
            {
                stringBuilder.AppendLine(this.Body);
            }

            return stringBuilder.ToString();
        }
    }
}