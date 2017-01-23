using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    class Student
    {
        private string tel = "";
        private string email ="";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FN { get; set; }
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
        public List<double> Marks { get; set; }
        public Group GroupStudent { get; set; }

        public Student() { }

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
            result.Append("Name: " + this.FirstName + " " + this.LastName + "\n");
            result.Append("Age: " + this.Age + ", ");
            result.Append("FN: " + this.FN + ", ");
            result.Append("Telephone: " + this.Tel + ", ");
            result.Append("Email: " + this.Email + ", ");
            result.Append("Group number: " + this.GroupStudent.GroupNumber + ", ");
            result.Append("Department name: " + this.GroupStudent.DepartmentName + ", ");
            result.Append("Marks: ");

            foreach (var item in Marks)
            {
                result.Append(item + " ");    
            }

            result.Append("\n------------------------------------------------------------");

            return result.ToString();
        }
    }
}
