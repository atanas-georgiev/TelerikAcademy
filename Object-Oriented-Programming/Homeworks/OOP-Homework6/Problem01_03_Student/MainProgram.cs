using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01_03_Student
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test problem 1
            Student student1 = new Student
            {
                FirstName = "Atanas",
                MiddleName = "Vladimirov",
                LastName = "Georgiev",
                SSN = 123456,
                Address = "Sofia",
                Tel = "0888123456",
                Email = "atanas@mail.com",
                Course = "OOP",
                Facility = Student.FacilityType.Facility1,
                Speciality = Student.SpecialityType.Mathematics,
                Univerisity = Student.UniversityType.TU
            };

            Student student2 = new Student
            {
                FirstName = "Ivan",
                MiddleName = "Petrov",
                LastName = "Dimitrov",
                SSN = 111111,
                Address = "Sofia",
                Tel = "0888112233",
                Email = "ivan@mail.com",
                Course = "OOP",
                Facility = Student.FacilityType.Facility2,
                Speciality = Student.SpecialityType.Programming,
                Univerisity = Student.UniversityType.FreeUniversity
            };

            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine("Student1 equals Student2: " + student1.Equals(student2));
            Console.WriteLine("Student1 == Student2: " + (student1 == student2));
            Console.WriteLine("Student1 != Student2: " + (student1 != student2));
            Console.WriteLine("Student1 hash code: " + student1.GetHashCode());

            // Test problem 2
            Student student3 = (Student)student1.Clone();
            Console.WriteLine(student3);

            // Test problem 3
            Console.WriteLine("Student1 compare Student2: " + student1.CompareTo(student2));
        }
    }
}

