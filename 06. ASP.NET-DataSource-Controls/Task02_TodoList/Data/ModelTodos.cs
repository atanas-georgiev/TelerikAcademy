using Task02_TodoList.Migrations;

namespace Task02_TodoList.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodosDbContext : DbContext
    {
        // Your context has been configured to use a 'ModelTodos' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Task02_TodoList.Data.ModelTodos' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelTodos' 
        // connection string in the application configuration file.
        public TodosDbContext()
            : base("name=ModelTodos")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TodosDbContext, Configuration>());
        }
        
        public virtual DbSet<Todo> Todo { get; set; }
    }
}