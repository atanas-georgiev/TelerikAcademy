namespace Task01_Students
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        private const string FileName = "Students.txt";

        public static void Main()
        {
            string line;
            var courses = new SortedDictionary<string, SortedSet<string>>();

            // Read the file with students and fill in the dictionaries
            var file = new StreamReader(FileName);

            while ((line = file.ReadLine()) != null)
            {
                var student = line.Split('|');
                var studentFirstName = student[0].Trim();
                var studentLastName = student[1].Trim();
                var studentCourse = student[2].Trim();

                if (!courses.ContainsKey(studentCourse))
                {
                    courses.Add(studentCourse, new SortedSet<string>());                    
                }

                courses[studentCourse].Add(studentLastName + " " + studentFirstName);
            }

            file.Close();

            foreach (var course in courses)
            {
                Console.WriteLine(course.Key + ": " + string.Join(", ", course.Value));
            }
        }
    }
}
