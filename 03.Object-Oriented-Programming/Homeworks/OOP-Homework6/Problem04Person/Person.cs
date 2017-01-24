//Problem 4. Person class

// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
// Override ToString() to display the information of a person and if age is not specified – to say so.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04Person
{
    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid value!");
                else if (value == 0)
                    age = null;
                else
                    age = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\n", this.Name, age == null ? "No age specified" : age.ToString());
        }

    }
}
