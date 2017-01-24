//Problem 2. Students and workers

//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money 
//earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02StudentsAndWorkers
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> 
            {
                new Student("Peter", "Petrov", 2),
                new Student("Ivan", "Petrov", 3),
                new Student("Georgi", "Petrov", 6),
                new Student("Stamen", "Ivanov", 3),
                new Student("Atanas", "Georgiev", 5),
                new Student("Peter", "Georgiev", 2),
                new Student("Ivan", "Sharkov", 4),
                new Student("Georgi", "Ivanov", 4),
                new Student("Peter", "Georgiev", 4),
                new Student("Ivan", "Georgiev", 6)
            };

            var sortedStudents = from student
                                 in students
                                 orderby student.Grade
                                 select student;

            Console.WriteLine("Students");
            Console.WriteLine("------------------------------------------");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            List<Worker> workers = new List<Worker> 
            {
                new Worker("Peter", "Petrov",400,8),
                new Worker("Ivan", "Petrov",200,4),
                new Worker("Georgi", "Petrov",100,2),
                new Worker("Stamen", "Ivanov",20,1),
                new Worker("Atanas", "Georgiev",1000,10),
                new Worker("Peter", "Georgiev",4000,12),
                new Worker("Ivan", "Sharkov",120,4),
                new Worker("Georgi", "Ivanov",100,4),
                new Worker("Peter", "Georgiev",400,8),
                new Worker("Ivan", "Georgiev",800,10)
            };

            Console.WriteLine("Workers");
            Console.WriteLine("------------------------------------------");
            var sortedWorkers = from worker
                                 in workers
                                orderby worker.MoneyPerHour()
                                select worker;

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("All");
            Console.WriteLine("------------------------------------------");
            List<Human> all = new List<Human>();
            all.AddRange(students);
            all.AddRange(workers);
            var allHumans = from human in all
                            orderby human.FirstName, human.LastName
                            select human;

            foreach (var human in allHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
