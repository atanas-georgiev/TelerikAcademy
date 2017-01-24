// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task3.cs" company="">
//   
// </copyright>
// <summary>
//   The task 3.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    ///     The task 3.
    /// </summary>
    internal class Task3
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        ///     Write a program that retrieves from the Northwind database all product categories and the names of the products in
        ///     each category.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Product categories:");
                var selectRequest = "SELECT c.CategoryName [category], p.ProductName [product] FROM Products p "
                                    + "INNER JOIN Categories c " + "ON p.CategoryID = c.CategoryID "
                                    + "ORDER BY c.CategoryName";
                var cmdAllProducs = new SqlCommand(selectRequest, con);
                var reader = cmdAllProducs.ExecuteReader();
                var previousCatery = string.Empty;

                using (reader)
                {
                    while (reader.Read())
                    {
                        var category = (string)reader["category"];
                        var product = (string)reader["product"];

                        if (previousCatery != category)
                        {
                            Console.Write(Environment.NewLine + category + " ---> ");
                        }

                        Console.Write(product + ", ");
                        previousCatery = category;
                    }
                }
            }
        }
    }
}