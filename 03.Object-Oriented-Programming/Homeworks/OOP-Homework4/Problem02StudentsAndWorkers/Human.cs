using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02StudentsAndWorkers
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Human() { }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}", FirstName, LastName);
        }
    }
}
