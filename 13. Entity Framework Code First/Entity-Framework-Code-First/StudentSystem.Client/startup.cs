namespace StudentSystem.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.InteropServices;

    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;

    internal class Startup
    {
        internal static void Main()
        {
            var db = new StudentSystemContext();
            db.Database.Delete();
            db.Database.Create();

            // Add students
            Console.Write("\nAdding students");
            for (int i = 0; i < 10000; i++)
            {
                db.Students.Add(
                    new Student()
                    {
                        Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(2, 50)),
                        Number = RandomGenerator.RandomInt(1, 1000000)
                    });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                }
            }

            // Add courses
            Console.Write("\nAdding courses");
            for (int i = 0; i < 10000; i++)
            {
                db.Courses.Add(
                    new Course()
                    {
                        Name = RandomGenerator.RandomString(RandomGenerator.RandomInt(2, 100)),
                        Description = RandomGenerator.RandomString(RandomGenerator.RandomInt(20, 1000))
                    });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                }
            }

            // Get all student and courses ids
            var studentIds = db.Students.Select(x => x.Id).ToList();
            var courseIds = db.Courses.Select(x => x.Id).ToList();

            // Add homeworks
            Console.Write("\nAdding homeworks");
            for (int i = 0; i < 10000; i++)
            {
                db.Homeworks.Add(
                    new Homework()
                    {
                        Content = RandomGenerator.RandomString(RandomGenerator.RandomInt(20, 1000)),
                        TimeSpendMinutes = RandomGenerator.RandomInt(5, 500),
                        StudentId = studentIds[RandomGenerator.RandomInt(0, studentIds.Count)],
                        CourseId = courseIds[RandomGenerator.RandomInt(0, courseIds.Count)]
                    });

                if (i % 250 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                }
            }
        }
    }
}
