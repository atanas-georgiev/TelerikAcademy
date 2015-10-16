// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiControllerGetDateWithCorsTest.cs" company="">
//   
// </copyright>
// <summary>
//   The api controller get date with cors test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Tests
{
    using System;

    using ConsoleWebServer.Application.Controllers;
    using ConsoleWebServer.Framework.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    /// <summary>
    /// The api controller get date with cors test.
    /// </summary>
    [TestClass]
    public class ApiControllerGetDateWithCorsTest
    {
        /// <summary>
        /// The is key result.
        /// </summary>
        private bool isKeyResult;

        /// <summary>
        /// The empty reuqest should throw.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyReuqestShouldThrow()
        {
            var mockedObj = this.HttpRequestMock().Object;
            var controloller = new ApiController(mockedObj);
            this.isKeyResult = true;
            var result = controloller.GetDateWithCors(string.Empty);
        }

        /// <summary>
        /// The http request mock.
        /// </summary>
        /// <returns>
        /// The <see cref="Mock"/>.
        /// </returns>
        private Mock<IHttpRequest> HttpRequestMock()
        {
            var mockedRequest = new Mock<IHttpRequest>();
            mockedRequest.Setup(r => r.Headers.ContainsKey(It.IsAny<string>())).Returns(() => this.isKeyResult);
            return mockedRequest;
        }
    }
}