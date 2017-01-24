namespace Task02_Todos.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodosDbContext : DbContext
    {
        public TodosDbContext()
            : base("name=ModelTodos")
        {
        }

        public virtual DbSet<Todo> Todo { get; set; }

        public virtual DbSet<Category> Category { get; set; }

    }

}