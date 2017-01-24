// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task10.cs" company="">
//   
// </copyright>
// <summary>
//   The task 10.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ado_net_homework
{
    using System;
    using System.Data.SQLite;

    /// <summary>
    /// The task 10.
    /// </summary>
    internal class Task10
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Data Source=:memory:;Version=3;New=True;";

        /// <summary>
        ///     Re-implement the previous task with SQLite embedded DB (see http://sqlite.phxsoftware.com).
        /// </summary>
        public static void Execute()
        {
            var con = new SQLiteConnection { ConnectionString = ConnectionString };
            con.Open();

            // create table
            var cmdNewTable =
                new SQLiteCommand(
                    "CREATE TABLE Books (title nvarchar(100) NOT NULL,author nvarchar(100)  NOT NULL,publishDate datetime,isbn Int NOT NULL)", 
                    con);
            cmdNewTable.ExecuteNonQuery();

            // insert simple data
            var cmdInsertInTable =
                new SQLiteCommand("INSERT INTO books(title, author, isbn) values ('test', 'test', 123)", con);
            cmdInsertInTable.ExecuteNonQuery();

            // get all books
            var cmdReadFromTable = new SQLiteCommand(" SELECT title, author, publishDate, isbn from Books", con);
            var reader = cmdReadFromTable.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    var title = (string)reader["title"];
                    var author = (string)reader["author"];
                    var isbn = (int)reader["isbn"];

                    Console.WriteLine(title + " " + author + " " + isbn);
                }
            }
        }
    }
}