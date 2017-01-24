// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task2.cs" company="">
//   
// </copyright>
// <summary>
//   The task 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    ///     The task 2.
    /// </summary>
    internal class Task2
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        ///     Write a program that retrieves the name and description of all categories in the Northwind DB.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Name and description of the categories:");
                var cmdAllEmployees = new SqlCommand("SELECT CategoryName, Description FROM Categories", con);
                var reader = cmdAllEmployees.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var category = (string)reader["CategoryName"];
                        var description = (string)reader["Description"];
                        Console.WriteLine(category + " ---> " + description);
                    }
                }
            }
        }
    }
}