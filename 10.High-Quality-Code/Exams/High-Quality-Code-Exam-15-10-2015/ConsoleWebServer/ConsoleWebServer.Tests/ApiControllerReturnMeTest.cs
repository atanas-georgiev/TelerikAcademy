// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiControllerReturnMeTest.cs" company="">
//   
// </copyright>
// <summary>
//   The api controller return me test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Tests
{
    using System;
    using System.Net;

    using ConsoleWebServer.Application.Controllers;
    using ConsoleWebServer.Framework.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     The api controller return me test.
    /// </summary>
    [TestClass]
    public class ApiControllerReturnMeTest
    {
        /// <summary>
        ///     The empty reuqest should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void EmptyReuqestShouldThrow()
        {
            var httpReq = new HttpRequest(string.Empty);
            var controloller = new ApiController(httpReq);
            var result = controloller.ReturnMe("test").GetResponse();
        }

        /// <summary>
        ///     The correct request should return ok result.
        /// </summary>
        [TestMethod]
        public void CorrectRequestShouldReturnOKResult()
        {
            var httpReq = new HttpRequest("GET /Home/LivePage HTTP/1.1");
            var controloller = new ApiController(httpReq);
            var result = controloller.ReturnMe("test").GetResponse();
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
        }
    }
}