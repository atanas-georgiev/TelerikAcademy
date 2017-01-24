// --------------------------------------------------------------------------------------------------------------------
// <copyright file="School.cs" company="">
//   
// </copyright>
// <summary>
//   The school.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task1_School
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The school.
    /// </summary>
    public class School
    {
        /// <summary>
        ///     The courses.
        /// </summary>
        private readonly List<Course> courses;

        /// <summary>
        ///     Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        public School()
        {
            this.courses = new List<Course>();
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="course">
        /// The course.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public void Add(Course course)
        {
            this.courses.Add(course);
        }
    }
}