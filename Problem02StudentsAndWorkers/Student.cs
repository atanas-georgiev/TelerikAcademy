using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02StudentsAndWorkers
{
    class Student : Human
    {
        public int Grade { get; set; }
        public Student() { }

        public Student(int grade)
        {
            this.Grade = grade;
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}, Grade = {2}", base.FirstName, base.LastName, Grade);
        }
    }
}
