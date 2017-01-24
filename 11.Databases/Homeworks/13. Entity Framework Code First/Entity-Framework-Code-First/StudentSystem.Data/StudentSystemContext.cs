namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Models;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() : 
            base("StudentSystemDb")
        {             
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }
    }
}
