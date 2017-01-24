using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_School;

namespace School.Tests
{
    [TestClass]
    public class Test_Student
    {
        private const string VALID_NAME = "Nasko";

        private const string NOT_VALID_NAME = "";

        private const int VALID_NUMBER = 12345;

        private const int NOT_VALID_NUMBER = 123;

        [TestMethod]
        public void Test_StudentWithValidParameters()
        {
            var st = new Student(VALID_NAME, VALID_NUMBER);

            Assert.IsTrue(st.Name == VALID_NAME && st.Number == VALID_NUMBER, "Name and numbers are not corrent!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_StudentWithInvalidName()
        {
            var st = new Student(NOT_VALID_NAME, VALID_NUMBER);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_StudentWithInvalidNumber()
        {
            var st = new Student(VALID_NAME, NOT_VALID_NUMBER);
        }
        
    }
}
