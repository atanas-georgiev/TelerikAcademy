// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="">
//   
// </copyright>
// <summary>
//   The student.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task1_School
{
    using System;

    /// <summary>
    ///     The student.
    /// </summary>
    public class Student
    {
        /// <summary>
        ///     The name.
        /// </summary>
        private string name;

        /// <summary>
        ///     The number.
        /// </summary>
        private int number;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="number">
        /// The number.
        /// </param>
        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        /// <summary>
        ///     Gets or sets the number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// </exception>
        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Number must be in range 10000 - 99999");
                }

                this.number = value;
            }
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// </exception>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null");
                }

                this.name = value;
            }
        }
    }
}