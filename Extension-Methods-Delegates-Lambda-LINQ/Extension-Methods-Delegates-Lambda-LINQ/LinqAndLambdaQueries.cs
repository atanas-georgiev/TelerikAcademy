using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    static class LinqAndLambdaQueries
    {
        /// <summary>
        /// Problem 3. First before last
        /// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        /// Use LINQ query operators.
        /// </summary>
        public static Student[] FindFirstBeforeLast(Student[] input)
        {
            var names =
                from name
                in input
                where String.Compare(name.FirstName, name.LastName, StringComparison.CurrentCulture) < 0
                select name;
            return names.ToArray<Student>();
        }

        /// <summary>
        /// Problem 4. Age range
        /// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        /// </summary>
        public static Array AgeRange(Student[] input)
        {
            var names =
                from name
                in input
                where name.Age >= 18 && name.Age <= 25
                select new { name.FirstName, name.LastName };
            return names.ToArray();
        }

        /// <summary>
        /// Problem 5. Order students
        /// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
        /// Rewrite the same with LINQ.
        /// </summary>
        public static Student[] OrderStudentsLambda(Student[] input)
        {
            var names = input.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            return names.ToArray<Student>();
        }

        public static Student[] OrderStudentsLinq(Student[] input)
        {
            var names =
                from name
                in input
                orderby name.LastName, name.LastName
                select name;
            return names.ToArray<Student>();
        }

        /// <summary>
        /// Problem 6. Divisible by 7 and 3
        /// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
        /// </summary>
        public static int[] FindDivisibleByThreeAndSevenLambda(int[] input)
        {
            var numbers = input.Where(x => x % 3 == 0 && x % 7 == 0);
            return numbers.ToArray<int>();
        }
        public static int[] FindDivisibleByThreeAndSevenLinq(int[] input)
        {
            var numbers =
                from number
                in input
                where (number % 3 == 0) && (number % 7 == 0)
                select number;
            return numbers.ToArray<int>();
        }

        /// <summary>
        /// Problem 9.
        /// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        /// Create a List<Student> with sample students. Select only the students that are from group number 2.
        /// Use LINQ query. Order the students by FirstName.
        /// </summary>
        public static List<Student> FindStudentsGroupTwo(List<Student> input)
        {
            var names =
                from name
                in input
                where name.GroupStudent.GroupNumber == 2
                orderby name.LastName
                select name;
            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 11.
        /// Extract all students that have email in abv.bg.
        /// Use string methods and LINQ.
        /// </summary>
        public static List<Student> ExtractAllMails(List<Student> input)
        {
            var names =
                from name
                in input
                where name.Email.EndsWith("abv.bg", true, System.Globalization.CultureInfo.InvariantCulture)
                orderby name.LastName
                select name;
            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 12.
        /// Extract all students with phones in Sofia.
        /// Use LINQ.
        /// </summary>
        public static List<Student> ExtractAllWithPhonesInSofia(List<Student> input)
        {
            var names =
                from name
                in input
                where name.Tel.Contains("003592") || name.Tel.Contains("+3592")
                select name;
            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 13.
        /// Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        /// Use LINQ.
        /// </summary>
        public static void ExtractStudentsMarks(List<Student> input)
        {
            var names =
                from name
                in input
                where name.Marks.Contains(6)
                select new { name.FirstName, name.Marks };

            foreach (var item in names)
            {
                Console.WriteLine();
                Console.Write("Name: " + item.FirstName);
                Console.Write("\nMarks: ");

                foreach (var mark in item.Marks)
                {
                    Console.Write(mark + " ");
                }
            }
        }

        /// <summary>
        /// Problem 15.
        /// Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        /// </summary>
        public static List<Student> ExtractAllWithFNin2006(List<Student> input)
        {
            var names =
                from name
                in input
                where name.FN.ToString().Substring(4, 2) == "06"
                select name;
            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 16.*
        /// Create a class Group with properties GroupNumber and DepartmentName.
        /// Introduce a property Group in the Student class.
        /// Extract all students from "Mathematics" department.
        /// Use the Join operator.
        /// </summary>
        public static List<Student> ExtractStudentGroups(List<Student> input, List<Group> groups)
        {
            var names =
                from name in input
                join gr in groups on name.GroupStudent.DepartmentName equals gr.DepartmentName
                select name;
            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 17.
        /// Write a program to return the string with maximum length from an array of strings.
        /// Use LINQ.
        /// </summary>
        public static string StringWithMaxLen(List<string> input)
        {
            var longest =
                    (from l
                    in input
                     where l.Length == input.Max(x => x.Length)
                     select l).FirstOrDefault();

            return longest.ToString();
        }

        /// <summary>
        /// Problem 18.
        /// Create a program that extracts all students grouped by GroupName and then prints them to the console.
        /// Use LINQ.
        /// </summary>
        public static List<Student> GroupByGroupName(List<Student> input)
        {
            var names =
                from name in input
                group name by name.GroupStudent.DepartmentName into newNames
                select newNames;

            return names.SelectMany(x => x).ToList<Student>();
        }
    }
}
