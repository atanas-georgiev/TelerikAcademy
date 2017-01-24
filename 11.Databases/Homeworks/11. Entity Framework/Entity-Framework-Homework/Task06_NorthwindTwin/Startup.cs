namespace Task06_NorthwindTwin
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                // 6. Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext
                // Initial catalog set to NorthWind twin in App.config
                var result = db.Database.CreateIfNotExists();
                Console.WriteLine("Table NorthwindTwin created + ", result);
            }
        }
    }
}
