// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task5.cs" company="">
//   
// </copyright>
// <summary>
//   The task 5.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ado_net_homework
{
    using System.Data.SqlClient;
    using System.IO;

    /// <summary>
    ///     The task 5.
    /// </summary>
    internal class Task5
    {
        /// <summary>
        ///     The connection string.
        /// </summary>
        private const string ConnectionString = "Server=.; database=Northwind; Integrated Security=SSPI";

        /// <summary>
        /// The write binary file.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <param name="fileContents">
        /// The file contents.
        /// </param>
        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            var stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }

        /// <summary>
        ///     Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files
        ///     in the file system.
        /// </summary>
        public static void Execute()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString };
            con.Open();

            using (con)
            {
                var cmdPictures = new SqlCommand("SELECT CategoryName, Picture FROM Categories", con);
                var reader = cmdPictures.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var category = (string)reader["CategoryName"];
                        var picture = (byte[])reader["Picture"];

                        WriteBinaryFile(".\\" + category + ".jpg", picture);
                    }
                }
            }
        }
    }
}