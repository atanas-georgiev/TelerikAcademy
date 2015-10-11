// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task6.cs" company="">
//   
// </copyright>
// <summary>
//   The task 6.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System;
    using System.Data.OleDb;

    /// <summary>
    ///     The task 6.
    /// </summary>
    internal class Task6
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.xls;Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";";

        /// <summary>
        ///     Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row
        ///     by row.
        /// </summary>
        public static void Execute()
        {
            var con = new OleDbConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                Console.WriteLine("Name and score of the categories:");
                var cmdAllScores = new OleDbCommand("SELECT Name, Score FROM [Sheet1$]", con);
                var reader = cmdAllScores.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader[0];
                        var score = (double)reader[1];
                        Console.WriteLine(name + " ---> " + score);
                    }
                }
            }
        }
    }
}