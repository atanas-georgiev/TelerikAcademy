// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task1.cs" company="">
//   
// </copyright>
// <summary>
//   The task 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    ///     The task 1.
    /// </summary>
    internal static class Task1
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        ///     Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the
        ///     Categories table.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                var cmdCount = new SqlCommand("SELECT COUNT(*) FROM Categories", con);
                var categoriesCnt = (int)cmdCount.ExecuteScalar();

                Console.WriteLine("Categories count " + categoriesCnt);
                Console.WriteLine();
            }
        }
    }
}