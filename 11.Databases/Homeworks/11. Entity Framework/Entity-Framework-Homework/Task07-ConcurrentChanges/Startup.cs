namespace Task07_ConcurrentChanges
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Establish connection to the database");
            
            using (var firstConnection = new NorthwindEntities())
            {
                var employee = firstConnection.Employees.Find(1);
                Console.WriteLine("Name of the first employee: {0}", employee.FirstName);

                employee.FirstName = "Pesho";
                Console.WriteLine("Name changed to : {0}", employee.FirstName);

                Console.WriteLine("Establish second connection to the database");

                using (var secondConnection = new NorthwindEntities())
                {
                    var employee2 = secondConnection.Employees.Find(1);
                    Console.WriteLine("Name of the first employee: {0}", employee2.FirstName);

                    employee2.FirstName = "Gosho";
                    Console.WriteLine("Name changed to : {0}", employee2.FirstName);

                    firstConnection.SaveChanges();
                    secondConnection.SaveChanges();
                }

                Console.WriteLine("Name after saving: {0}", employee.FirstName);
            }
        }
    }
}
