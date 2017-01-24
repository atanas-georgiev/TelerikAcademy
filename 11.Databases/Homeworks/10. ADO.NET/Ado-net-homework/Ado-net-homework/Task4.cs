// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task4.cs" company="">
//   
// </copyright>
// <summary>
//   The task 4.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    ///     The task 4.
    /// </summary>
    internal class Task4
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        ///     Write a method that adds a new product in the products table in the Northwind database.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Enter product name:");
                var product = Console.ReadLine();

                var cmdAddProducts = new SqlCommand(
                    "INSERT INTO Products(ProductName, Discontinued) VALUES (@name, 0)", 
                    con);
                cmdAddProducts.Parameters.AddWithValue("@name", product);
                cmdAddProducts.ExecuteNonQuery();
            }
        }
    }
}