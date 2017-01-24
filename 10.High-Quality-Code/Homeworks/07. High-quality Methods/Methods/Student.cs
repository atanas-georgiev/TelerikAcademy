// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The student.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Methods
{
    using System;

    /// <summary>
    ///     The student.
    /// </summary>
    internal class Student
    {
        /// <summary>
        ///     The first name.
        /// </summary>
        private string firstName;

        /// <summary>
        ///     The last name.
        /// </summary>
        private string lastName;

        /// <summary>
        ///     The other info.
        /// </summary>
        private string otherInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="lastName">
        /// The last name.
        /// </param>
        /// <param name="info">
        /// The info.
        /// </param>
        public Student(string firstName, string lastName, string info)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = info;
        }

        /// <summary>
        ///     Gets the first name.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Null data
        /// </exception>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("No first name entered!");
                }

                this.firstName = value;
            }
        }

        /// <summary>
        ///     Gets the last name.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Null data
        /// </exception>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("No last name entered!");
                }

                this.lastName = value;
            }
        }

        /// <summary>
        ///     Gets the other info.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Null data
        /// </exception>
        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("No additional info entered!");
                }

                this.otherInfo = value;
            }
        }

        /// <summary>
        /// The is older than.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsOlderThan(Student other)
        {
            try
            {
                var firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
                var secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
                return firstDate > secondDate;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid format entered!");
            }
        }
    }
}