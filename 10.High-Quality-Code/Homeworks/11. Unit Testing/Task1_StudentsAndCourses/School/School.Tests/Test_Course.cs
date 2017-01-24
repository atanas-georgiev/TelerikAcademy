using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    using Task1_School;

    [TestClass]
    public class Test_Course
    {
        private const string VALID_NAME = "Nasko";
        
        private const int VALID_NUMBER = 12345;

        [TestMethod]
        public void Test_CourseWithValidStudentShouldNotThrow()
        {
            var st = new Student(VALID_NAME, VALID_NUMBER);
            var course = new Course();
            try
            {
                course.Join(st);
                course.Leave(st);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CourseJoinStudentTwiceShouldThrow()
        {
            var st = new Student(VALID_NAME, VALID_NUMBER);
            var course = new Course();
            course.Join(st);
            course.Join(st);                         
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_LeaveNotExistingStudentShouldThrow()
        {
            var st = new Student(VALID_NAME, VALID_NUMBER);
            var course = new Course();
            course.Leave(st);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddTooManyStudentsShouldThrow()
        {
            var course = new Course();

            for (int i = 0; i < 50; i++)
            {
                var st = new Student(VALID_NAME, VALID_NUMBER + 1);
                course.Join(st);
            }
        }
    }
}
