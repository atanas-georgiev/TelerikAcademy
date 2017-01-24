// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task7.cs" company="">
//   
// </copyright>
// <summary>
//   The task 7.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.OleDb;

    /// <summary>
    ///     The task 7.
    /// </summary>
    internal class Task7
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.xls;Extended Properties = \"Excel 8.0;HDR=Yes\";";

        /// <summary>
        ///     Implement appending new rows to the Excel file.
        /// </summary>
        public static void Execute()
        {
            var con = new OleDbConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Enter name:");
                var name = Console.ReadLine();
                Console.WriteLine("Enter score:");
                var score = double.Parse(Console.ReadLine());

                var cmdAllScores = new OleDbCommand();
                cmdAllScores.Connection = con;
                cmdAllScores.CommandText = "INSERT INTO[Sheet1$] (Name, Score) VALUES (@name, @score)";
                cmdAllScores.Parameters.AddWithValue("@name", name);
                cmdAllScores.Parameters.AddWithValue("@score", score);
                cmdAllScores.ExecuteNonQuery();
            }
        }
    }
}