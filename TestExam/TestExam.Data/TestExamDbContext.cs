using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using TestExam.Data.Models;

namespace TestExam.Data
{
    public class TestExamDbContext : IdentityDbContext<User>, ITestExamDbContext
    {
        public TestExamDbContext()
            : base("TestExamDbConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<TextExamItem> TextExamItems { get; set; }

        public static TestExamDbContext Create()
        {
            return new TestExamDbContext();
        }
    }
}
