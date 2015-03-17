//Problem 1. Student class

//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem01_03_Student
{
    class Student : ICloneable, IComparable<Student>
    {
        private string tel = "";
        private string email = "";
        public enum SpecialityType
        {
            Mathematics,
            Physics,
            Programming,
            Literature
        }

        public enum UniversityType
        {
            TU,
            SU,
            FreeUniversity
        }

        public enum FacilityType
        {
            Facility1,
            Facility2,
            Facility3
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (CheckNumber(value))
                {
                    this.tel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid telephone");
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (CheckEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid email");
                }
            }
        }
        public string Course { get; set; }
        public SpecialityType Speciality { get; set; }
        public UniversityType Univerisity { get; set; }
        public FacilityType Facility { get; set; }

        public Student() { }
        public Student(string firstName = "NoName", string middleName = "NoName", string lastName = "NoName",
            ulong ssn = 0, string address = "No Address", string tel = "0888000000", string email = "email@example.com",
            string course = "No course", SpecialityType spec = SpecialityType.Mathematics,
            UniversityType university = UniversityType.FreeUniversity, FacilityType facility = FacilityType.Facility1)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Tel = tel;
            this.Email = email;
            this.Univerisity = university;
            this.Facility = facility;
            this.Speciality = spec;
        }

        private static bool CheckNumber(string strPhoneNumber)
        {
            string MatchPhoneNumberPattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            if (strPhoneNumber != null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern);
            else return false;
        }
        private static bool CheckEmail(string strPhoneNumber)
        {
            string MatchPhoneNumberPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (strPhoneNumber != null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern);
            else return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\n------------------------------------------------------------\n");
            result.Append("Name: " + this.FirstName + " " + this.MiddleName + " " + this.LastName + "\n");
            result.Append("SSN: " + this.SSN + ", ");
            result.Append("Address: " + this.Address + ", ");
            result.Append("Telephone: " + this.Tel + ", ");
            result.Append("Email: " + this.Email + ", ");
            result.Append("Univerisity: " + this.Univerisity + ", ");
            result.Append("Speciality: " + this.Speciality + ", ");
            result.Append("Facility: " + this.Facility);
            result.Append("\n------------------------------------------------------------");
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            if ((object)s == null)
            {
                return false;
            }

            if (this.FirstName == s.FirstName &&
                this.MiddleName == s.MiddleName &&
                this.LastName == s.LastName &&
                this.SSN == s.SSN &&
                this.Address == s.Address &&
                this.Tel == s.Tel &&
                this.Email == s.Email &&
                this.Univerisity == s.Univerisity &&
                this.Facility == s.Facility &&
                this.Speciality == s.Speciality)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (int)this.SSN;
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Problem 2. IClonable
        /// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        /// </summary>
        public object Clone()
        {
            Student newStudent = new Student();
            newStudent.FirstName = (string)this.FirstName.Clone();
            newStudent.MiddleName = (string)this.MiddleName.Clone();
            newStudent.LastName = (string)this.LastName.Clone();
            newStudent.SSN = this.SSN;
            newStudent.Address = (string)this.Address.Clone();
            newStudent.Tel = (string)this.Tel.Clone();
            newStudent.Email = (string)this.Email.Clone();
            newStudent.Univerisity = this.Univerisity;
            newStudent.Speciality = this.Speciality;
            newStudent.Facility = this.Facility;            
            return newStudent;
        }

        /// <summary>
        /// Problem 3. IComparable
        /// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
        /// </summary>
        public int CompareTo(Student other)
        {
            var res = String.Compare(this.FirstName, other.FirstName);
            
            if (res != 0)
            {
                return res;
            }
            else
            {
                return (int)(this.SSN - other.SSN);
            }
        }
    }
}
