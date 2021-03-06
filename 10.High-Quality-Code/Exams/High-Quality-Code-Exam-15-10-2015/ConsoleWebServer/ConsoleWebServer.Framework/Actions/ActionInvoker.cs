﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionInvoker.cs" company="">
//   
// </copyright>
// <summary>
//   The action invoker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Framework.Actions
{
    using System;
    using System.Linq;
    using System.Reflection;

    using ConsoleWebServer.Framework.Exceptions;

    /// <summary>
    ///     The action invoker.
    /// </summary>
    public class ActionInvoker
    {
        /// <summary>
        /// The invoke action.
        /// </summary>
        /// <param name="controller">
        /// The controller.
        /// </param>
        /// <param name="descriptior">
        /// The descriptior.
        /// </param>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        /// <exception cref="HttpNotFoundException">
        /// </exception>
        /// <exception cref="Exception">
        /// </exception>
        public IActionResult InvokeAction(Controller controller, ActionDescriptor descriptior)
        {
            /*
 * Child processes that use such C run-time functions as printf() and fprintf() can behave poorly when redirected.
 * The C run-time functions maintain separate IO buffers. When redirected, these buffers might not be flushed immediately after each IO call.
 * As a result, the output to the redirection pipe of a printf() call or the input from a getch() call is not flushed immediately and delays, sometimes-infinite delays occur.
 * This problem is avoided if the child process flushes the IO buffers after each call to a C run-time IO function.
 * Only the child process can flush its C run-time IO buffers. A process can flush its C run-time IO buffers by calling the fflush() function.
 */
            var methodWithIntParameter =
                controller.GetType()
                    .GetMethods()
                    .FirstOrDefault(
                        x =>
                        x.Name.ToLower() == descriptior.ActionName.ToLower() && x.GetParameters().Length == 1
                        && x.GetParameters()[0].ParameterType == typeof(string) && x.ReturnType == typeof(IActionResult));
            if (methodWithIntParameter == null)
            {
                throw new HttpNotFoundException(
                    string.Format(
                        "Expected method with signature IActionResult {0}(string) in class {1}Controller", 
                        descriptior.ActionName, 
                        descriptior.ControllerName));
            }

            try
            {
                var actionResult =
                    (IActionResult)methodWithIntParameter.Invoke(controller, new object[] { descriptior.Parameter });
                return actionResult;
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }
    }
}