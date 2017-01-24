using System.Data.Entity;

namespace Task01_Towns.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TownsDbContext : DbContext
    {
        // Your context has been configured to use a 'ModelTowns' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Task01_Towns.ModelTowns' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelTowns' 
        // connection string in the application configuration file.
        public TownsDbContext()
            : base("name=ModelTowns")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Continent> Continents { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}