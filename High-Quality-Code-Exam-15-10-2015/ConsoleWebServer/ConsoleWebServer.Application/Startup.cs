// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="">
//   
// </copyright>
// <summary>
//   The startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Application
{
    using ConsoleWebServer.Framework.Handlers;

    /// <summary>
    ///     The startup.
    /// </summary>
    public static class Startup
    {
        /// <summary>
        ///     The main.
        /// </summary>
        public static void Main()
        {
            var webSever = new WebServerConsole(new ResponseProvider());
            webSever.Start();
        }
    }
}