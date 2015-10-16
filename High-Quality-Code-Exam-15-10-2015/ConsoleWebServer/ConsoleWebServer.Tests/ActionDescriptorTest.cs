// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionDescriptorTest.cs" company="">
//   
// </copyright>
// <summary>
//   The action descriptor test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConsoleWebServer.Tests
{
    using ConsoleWebServer.Framework.Actions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     The action descriptor test.
    /// </summary>
    [TestClass]
    public class ActionDescriptorTest
    {
        /// <summary>
        ///     The test action descriptor with null data should return default.
        /// </summary>
        [TestMethod]
        public void TestActionDescriptorWithNullDataShouldReturnDefault()
        {
            var desc = new ActionDescriptor(null);
            Assert.AreEqual(desc.ToString(), @"/Home/Index/Param");
        }

        /// <summary>
        ///     The test action descriptor with empty data should return default data.
        /// </summary>
        [TestMethod]
        public void TestActionDescriptorWithEmptyDataShouldReturnDefaultData()
        {
            var desc = new ActionDescriptor(string.Empty);
            Assert.AreEqual(desc.ToString(), @"/Home/Index/Param");
        }

        /// <summary>
        ///     The test action descriptor with valid data should return correct.
        /// </summary>
        [TestMethod]
        public void TestActionDescriptorWithValidDataShouldReturnCorrect()
        {
            var desc = new ActionDescriptor("a/b/c");
            Assert.AreEqual(desc.ToString(), @"/a/b/c");
        }
    }
}