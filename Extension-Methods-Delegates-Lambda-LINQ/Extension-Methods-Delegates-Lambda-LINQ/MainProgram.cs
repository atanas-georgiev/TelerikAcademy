using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // test Problem 1. StringBuilder.Substring
            Console.WriteLine("\nProblem 1. StringBuilder.Substring");
            Console.WriteLine("------------------------------------");
            StringBuilder str = new StringBuilder();
            str.Append("aaaaaaaabbbbbbbbbbbbbccccccccccccc");
            Console.WriteLine("Original string is: {0}", str);
            Console.WriteLine("Substring is: {0}", str.SubString(0, 8));

            // test Problem 2. IEnumerable extensions
            Console.WriteLine("\nProblem 2. IEnumerable extensions");
            Console.WriteLine("------------------------------------");

            Console.Write("Input values: ");
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nSum: " + ints.SumExt<int>());
            Console.Write("\nProduct: " + ints.ProductExt<int>());
            Console.Write("\nMin: " + ints.MinExt<int>());
            Console.Write("\nMax: " + ints.MaxExt<int>());
            Console.WriteLine();

            Student[] students = new Student[]
            {
                new Student {FirstName = "Peter", LastName = "Petrov", Age = 18, Tel = "0888123456", Email="peter@petrov.com", FN=121205,  
                     GroupStudent = new Group(1, "Mathematics"), Marks = new List<double> {2,3,4,5}},
                new Student {FirstName = "Ivan", LastName = "Ivanov", Age = 15,Tel = "0888123457", Email="ivan.ivanov@abv.bg", FN=155405, 
                     GroupStudent = new Group(1, "Phisycs"), Marks = new List<double> {6,6,6,6}},
                new Student {FirstName = "Atanas", LastName = "Ivanov", Age = 22,Tel = "0888827364", Email="atanas.ivanov@abv.bg", FN=432106, 
                     GroupStudent = new Group(2, "Mathematics"), Marks = new List<double> {4,2,2,6}},
                new Student {FirstName = "Peter", LastName = "Ivanov", Age = 44,Tel = "003592123456", Email="peter.ivanov@gmail.com", FN=152306, 
                     GroupStudent = new Group(2, "Phisycs"), Marks = new List<double> {2,2,2,2}}
            };

            // test Problem 3. First before last
            Console.WriteLine("\nProblem 3. First before last");
            Console.WriteLine("------------------------------------");
            foreach (var item in LinqAndLambdaQueries.FindFirstBeforeLast(students))
            {
                Console.WriteLine(item);
            }

            // test Problem 4. Age range
            Console.WriteLine("\nProblem 4. Age range");
            Console.WriteLine("------------------------------------");
            foreach (var item in LinqAndLambdaQueries.AgeRange(students))
            {
                Console.WriteLine(item);
            }

            // test Problem 5. Order students
            Console.WriteLine("\nProblem 5. Order students");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nWith lambda");
            foreach (var item in LinqAndLambdaQueries.OrderStudentsLambda(students))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWith LINQ");
            foreach (var item in LinqAndLambdaQueries.OrderStudentsLinq(students))
            {
                Console.WriteLine(item);
            }

            // test Problem 6. Divisible by 7 and 3
            int[] numbers = new int[] { 1, 21, 42, 34, 23, 210 };
            Console.WriteLine("\nProblem 6. Divisible by 7 and 3");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nWith lambda");
            foreach (var item in LinqAndLambdaQueries.FindDivisibleByThreeAndSevenLambda(numbers))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nWith LINQ");
            foreach (var item in LinqAndLambdaQueries.FindDivisibleByThreeAndSevenLinq(numbers))
            {
                Console.Write(item + " ");
            }

            List<Student> studentsList = students.ToList<Student>();

            // test Problem 9. Students from group number 2
            Console.WriteLine("\nProblem 9. Students from group number 2");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nWith LINQ");
            foreach (var item in LinqAndLambdaQueries.FindStudentsGroupTwo(studentsList))
            {
                Console.WriteLine(item);
            }

            // test Problem 10. Students from group number 2
            Console.WriteLine("\nProblem 10. Students from group number 2");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nWith Extension methods");
            foreach (var item in studentsList.FindStudentsGroupTwo())
            {
                Console.WriteLine(item);
            }

            // test Problem 11. Students with mails in abv.bg
            Console.WriteLine("\nProblem 11. Students with mails in abv.bg");
            Console.WriteLine("------------------------------------");
            foreach (var item in LinqAndLambdaQueries.ExtractAllMails(studentsList))
            {
                Console.WriteLine(item);
            }

            // test Problem 12. Students with phones in Sofia
            Console.WriteLine("\nProblem 12. Students with phones in Sofia");
            Console.WriteLine("------------------------------------");
            foreach (var item in LinqAndLambdaQueries.ExtractAllWithPhonesInSofia(studentsList))
            {
                Console.WriteLine(item);
            }

            // test Problem 13. Students with at least one mark 6
            Console.WriteLine("\nProblem 13. Students with at least one mark 6");
            Console.WriteLine("------------------------------------");
            LinqAndLambdaQueries.ExtractStudentsMarks(studentsList);

            // test Problem 14. Students with exactly two marks 2
            Console.WriteLine();
            Console.WriteLine("\nProblem 14. Students with exactly two marks 2");
            Console.WriteLine("------------------------------------");
            foreach (var item in studentsList.ExtractExactlyTwoMarks())
            {
                Console.WriteLine(item);
            }

            // test Problem 16. Students from gorup Mathematics
            Console.WriteLine();
            Console.WriteLine("\nProblem 16. Students from gorup Mathematics");
            Console.WriteLine("------------------------------------");
            List<Group> grList = new List<Group>();
            grList.Add(new Group(1, "Mathematics"));
            foreach (var item in LinqAndLambdaQueries.ExtractStudentGroups(studentsList, grList))
            {
                Console.WriteLine(item);
            }

            // test Problem 17. Longest string
            Console.WriteLine();
            Console.WriteLine("\nProblem 17. Longest string");
            Console.WriteLine("------------------------------------");
            List<string> strings = new List<string> { "123", "1234", "12345", "1" };
            Console.WriteLine("Longest string is: " + LinqAndLambdaQueries.StringWithMaxLen(strings));

            // test Problem 18. Group by GroupName - LINQ
            Console.WriteLine();
            Console.WriteLine("\nProblem 18. Group by GroupName - LINQ");
            Console.WriteLine("------------------------------------");
            foreach (var item in LinqAndLambdaQueries.GroupByGroupName(studentsList))
            {
                Console.WriteLine(item);
            }

            // test Problem 19. Group by GroupName - Extension methods
            Console.WriteLine();
            Console.WriteLine("\nProblem 19. Group by GroupName - Extension methods");
            Console.WriteLine("------------------------------------");
            foreach (var item in studentsList.GroupByGrooupNames())
            {
                Console.WriteLine(item);
            }


        }
    }
}
