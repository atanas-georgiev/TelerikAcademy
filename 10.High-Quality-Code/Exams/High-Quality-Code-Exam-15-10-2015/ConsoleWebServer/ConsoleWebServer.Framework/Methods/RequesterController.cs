// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequesterController.cs" company="">
//   
// </copyright>
// <summary>
//   The requester controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Methods
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;

    using ConsoleWebServer.Framework.Actions;
    using ConsoleWebServer.Framework.Exceptions;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    ///     The requester controller.
    /// </summary>
    internal class RequesterController : Requester
    {
        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponse"/>.
        /// </returns>
        public override HttpResponse ProcessRequest(HttpRequest request)
        {
            if (request.ProtocolVersion.Major < 3)
            {
                HttpResponse response;

                try
                {
                    var controller = this.CreateController(request);
                    var actionResult = new ActionInvoker().InvokeAction(controller, request.Action);
                    response = actionResult.GetResponse();
                }
                catch (HttpNotFoundException exception)
                {
                    response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, exception.Message);
                }
                catch (Exception exception)
                {
                    response = new HttpResponse(
                        request.ProtocolVersion, 
                        HttpStatusCode.InternalServerError, 
                        exception.Message);
                }

                return response;
            }

            return new HttpResponse(
                request.ProtocolVersion, 
                HttpStatusCode.NotImplemented, 
                "Request cannot be handled.");
        }

        /// <summary>
        /// The create controller.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Controller"/>.
        /// </returns>
        /// <exception cref="HttpNotFoundException">
        /// </exception>
        private Controller CreateController(HttpRequest request)
        {
            var controllerClassName = request.Action.ControllerName + "Controller";
            var type =
                Assembly.GetEntryAssembly()
                    .GetTypes()
                    .FirstOrDefault(
                        x => x.Name.ToLower() == controllerClassName.ToLower() && typeof(Controller).IsAssignableFrom(x));
            if (type == null)
            {
                throw new HttpNotFoundException(
                    string.Format("Controller with name {0} not found!", controllerClassName));
            }

            var instance = (Controller)Activator.CreateInstance(type, request);
            return instance;
        }
    }
}