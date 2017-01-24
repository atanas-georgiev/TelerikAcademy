// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Course.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    /// <summary>
    ///     The course.
    /// </summary>
    internal abstract class Course
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class.
        /// </summary>
        /// <param name="courseName">
        /// The course name.
        /// </param>
        /// <param name="teacherName">
        /// The teacher name.
        /// </param>
        /// <param name="students">
        /// The students.
        /// </param>
        protected Course(string courseName, string teacherName = null, IList<string> students = null)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the teacher name.
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        ///     Gets or sets the students.
        /// </summary>
        public IList<string> Students { get; set; }

        /// <summary>
        ///     The get students as string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}