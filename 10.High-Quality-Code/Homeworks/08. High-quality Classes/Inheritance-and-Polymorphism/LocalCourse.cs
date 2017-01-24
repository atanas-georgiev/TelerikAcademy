// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocalCourse.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The local course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///     The local course.
    /// </summary>
    internal class LocalCourse : Course
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
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
        public LocalCourse(string courseName, string teacherName = null, IList<string> students = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        /// <summary>
        ///     Gets or sets the lab.
        /// </summary>
        public string Lab { get; set; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}