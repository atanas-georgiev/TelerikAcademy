// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task3_Filter_Orders
{
    using System;
    using System.Linq;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Startup
    {
        /// <summary>
        /// The query.
        /// </summary>
        private const string SqlQuery =
            "SELECT DISTINCT c.ContactName " + "FROM Customers c " + "INNER JOIN Orders o " + "ON c.CustomerID=o.CustomerID "
            + "WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            // 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            Console.WriteLine("Customers who have orders made in 1997 and shipped to Canada.");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Entity request:");
            Console.WriteLine("--------------------------------------------------------------");
            using (var db = new NorthwindEntities())
            {
                //var customers = (from c in db.Customers
                //                 join o in db.Orders on c.CustomerID equals o.CustomerID
                //                 where o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada"
                //                 select c).ToList();

                var customers = db.Customers.Where(c => c.Orders.Any(x => x.OrderDate != null && (x.OrderDate.Value.Year == 1997 && x.ShipCountry == "Canada"))).ToList(); 

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }

            // 4. Implement previous by using native SQL query and executing it through the DbContext.
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Sql request:");
            Console.WriteLine("--------------------------------------------------------------");
            using (var db = new NorthwindEntities())
            {
                var customers = db.Database.SqlQuery<string>(SqlQuery).ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }

            // 5. Write a method that finds all the sales by specified region and period (start / end dates).
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Sales by specified region and period (start / end dates).");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Enter region:");
            var region = Console.ReadLine();
            Console.WriteLine("Enter start date:");
            var startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter end date:");
            var endDate = DateTime.Parse(Console.ReadLine());

            using (var db = new NorthwindEntities())
            {
                var orders =
                    db.Orders.Where(o => startDate >= o.OrderDate && o.OrderDate <= endDate && o.ShipRegion == region)
                        .Select(x => new { Name = x.ShipName })
                        .ToList();

                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }
}