// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OffsiteCourse.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The offsite course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///     The offsite course.
    /// </summary>
    internal class OffsiteCourse : Course
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
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
        public OffsiteCourse(string courseName, string teacherName = null, IList<string> students = null)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        /// <summary>
        ///     Gets or sets the town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}