namespace TestExam.WebForms.App_Start
{
    using System.Data.Entity;
    using TestExam.Data;
    using TestExam.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestExamDbContext, Configuration>());
            TestExamDbContext.Create().Database.Initialize(true);
        }
    }
}