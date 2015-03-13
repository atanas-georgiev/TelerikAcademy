using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    static class StudentExtensions
    {
        /// <summary>
        /// Problem 10.
        /// Create a List<Student> with sample students. Select only the students that are from group number 2.
        /// Use LINQ query. Order the students by FirstName.        
        /// Implement the previous using the same query expressed with extension methods.
        /// </summary>
        public static List<Student> FindStudentsGroupTwo(this List<Student> input)
        {
            return LinqAndLambdaQueries.FindStudentsGroupTwo(input);
        }

        /// <summary>
        /// Problem 14.
        /// Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.
        /// </summary>
        public static List<Student> ExtractExactlyTwoMarks(this List<Student> input)
        {
            var names =
                from name
                in input
                where name.Marks.Count(x => x == 2) == 2
                select name;

            return names.ToList<Student>();
        }

        /// <summary>
        /// Problem 18.
        /// Create a program that extracts all students grouped by GroupName and then prints them to the console.
        /// Use extension methods.
        /// </summary>
        public static List<Student> GroupByGrooupNames(this List<Student> input)
        {
            return LinqAndLambdaQueries.GroupByGroupName(input);
        }
    }
}
