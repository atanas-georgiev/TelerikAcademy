using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    using Task1_School;

    [TestClass]
    public class Test_School
    {
        [TestMethod]
        public void Test_SchoolWithValidCourse()
        {                        
            try
            {
                var course = new Course();
                var school = new School();
                school.Add(course);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
