// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task8.cs" company="">
//   
// </copyright>
// <summary>
//   The task 8.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    ///     The task 8.
    /// </summary>
    internal class Task8
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        ///     Write a program that reads a string from the console and finds all products that contain this string.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Enter some string:");
                var data = Console.ReadLine();

                var cmdAllProducts = new SqlCommand(
                    "SELECT ProductName FROM Products WHERE ProductName LIKE @name", 
                    con);
                cmdAllProducts.Parameters.AddWithValue("@name", "%" + data + "%");
                var reader = cmdAllProducts.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var product = (string)reader["ProductName"];
                        Console.WriteLine(product);
                    }
                }
            }
        }
    }
}