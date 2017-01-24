// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Course.cs" company="">
//   
// </copyright>
// <summary>
//   The course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task1_School
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The course.
    /// </summary>
    public class Course
    {
        /// <summary>
        ///     The students.
        /// </summary>
        private readonly List<Student> students;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Course" /> class.
        /// </summary>
        public Course()
        {
            this.students = new List<Student>();
        }

        /// <summary>
        /// The join.
        /// </summary>
        /// <param name="student">
        /// The student.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public void Join(Student student)
        {
            if (this.students.Contains(student))
            {
                throw new ArgumentException("Student is already in this course");
            }

            if (this.students.Count >= 29)
            {
                throw new ArgumentException("Course is full");
            }

            this.students.Add(student);
        }

        /// <summary>
        /// The leave.
        /// </summary>
        /// <param name="student">
        /// The student.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public void Leave(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("Student is not in this course");
            }

            this.students.Remove(student);
        }
    }
}