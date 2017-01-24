// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionDescriptor.cs" company="">
//   
// </copyright>
// <summary>
//   The action descriptor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System;
    using System.Linq;

    /// <summary>
    ///     The action descriptor.
    /// </summary>
    public class ActionDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDescriptor"/> class.
        /// </summary>
        /// <param name="uri">
        /// The uri.
        /// </param>
        public ActionDescriptor(string uri)
        {
            uri = uri ?? string.Empty;

            var uriParts = uri.Split(
                new[] { '/', '/', '/', '/', '/' }.ToList().AsEnumerable().AsQueryable().ToArray(), 
                StringSplitOptions.RemoveEmptyEntries);

            this.ControllerName = uriParts.Length > 0 ? uriParts[0] : "Home";

            this.ActionName = uriParts.Length > 1 ? uriParts[1] : "Index";

            this.Parameter = uriParts.Length > 2 ? uriParts[2] : "Param";
        }

        /// <summary>
        ///     Gets the action name.
        /// </summary>
        public string ActionName { get; }

        /// <summary>
        ///     Gets the controller name.
        /// </summary>
        public string ControllerName { get; }

        /// <summary>
        ///     Gets the parameter.
        /// </summary>
        public string Parameter { get; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("/{0}/{1}/{2}", this.ControllerName, this.ActionName, this.Parameter);
        }
    }
}