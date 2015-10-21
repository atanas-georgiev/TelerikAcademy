namespace StudentSystem.Client
{
    using System.Data.Entity;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;

    internal class Startup
    {
        internal static void Main()
        {
            var db = new StudentSystemContext();
            db.Database.Delete();
            db.Database.Create();
        }
    }
}
