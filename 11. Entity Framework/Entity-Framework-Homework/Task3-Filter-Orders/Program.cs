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
    internal class Program
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
            Console.WriteLine("Customers who have orders made in 1997 and shipped to Canada.");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Entity request:");
            Console.WriteLine("--------------------------------------------------------------");
            using (var db = new NORTHWNDEntities())
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



            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Sql request:");
            Console.WriteLine("--------------------------------------------------------------");
            using (var db = new NORTHWNDEntities())
            {
                var customers = db.Database.SqlQuery<string>(SqlQuery).ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}