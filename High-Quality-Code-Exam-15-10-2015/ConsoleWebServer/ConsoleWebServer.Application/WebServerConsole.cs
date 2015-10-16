// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebServerConsole.cs" company="">
//   
// </copyright>
// <summary>
//   The web server console.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Application
{
    using System;
    using System.Text;

    using ConsoleWebServer.Framework.Handlers;

    /// <summary>
    ///     The web server console.
    /// </summary>
    public class WebServerConsole
    {
        /// <summary>
        ///     The response provider.
        /// </summary>
        private readonly IResponseProvider responseProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebServerConsole"/> class.
        /// </summary>
        /// <param name="responseProvider">
        /// The response Provider.
        /// </param>
        public WebServerConsole(IResponseProvider responseProvider)
        {
            this.responseProvider = responseProvider;
        }

        /// <summary>
        ///     The start.
        /// </summary>
        public void Start()
        {
            var requestBuilder = new StringBuilder();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == null)
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(inputLine))
                {
                    requestBuilder.AppendLine(inputLine);
                }
                else
                {
                    var response = this.responseProvider.GetResponse(requestBuilder.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(response);
                    Console.ResetColor();
                    requestBuilder.Clear();
                }
            }
        }
    }
}