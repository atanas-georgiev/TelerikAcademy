// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task9.cs" company="">
//   
// </copyright>
// <summary>
//   The task 9.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;

    using MySql.Data.MySqlClient;

    /// <summary>
    ///     The task 9.
    /// </summary>
    internal class Task9
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=naseto;Database=test;";

        /// <summary>
        ///     Download and install MySQL database, MySQL Connector/Net (.NET Data Provider for MySQL) + MySQL Workbench GUI
        ///     administration tool.
        /// </summary>
        public static void Execute()
        {
            var con = new MySqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                // create table
                var cmdNewTable =
                    new MySqlCommand(
                        "CREATE TABLE Books (title nvarchar(100) NOT NULL,author nvarchar(100)  NOT NULL,publishDate datetime NOT NULL,isbn Int NOT NULL)", 
                        con);
                cmdNewTable.ExecuteNonQuery();

                // insert simple data
                var cmdInsertInTable =
                    new MySqlCommand(
                        "INSERT INTO books(title, author, publishDate, isbn) values ('test', 'test', now(), 123)", 
                        con);
                cmdInsertInTable.ExecuteNonQuery();

                // get all books
                var cmdReadFromTable = new MySqlCommand(" SELECT title, author, publishDate, isbn from Books", con);
                var reader = cmdReadFromTable.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var title = (string)reader["title"];
                        var author = (string)reader["author"];
                        var publishDate = (DateTime)reader["publishDate"];
                        var isbn = (int)reader["isbn"];

                        Console.WriteLine(title + " " + author + " " + publishDate + " " + isbn);
                    }
                }
            }
        }
    }
}