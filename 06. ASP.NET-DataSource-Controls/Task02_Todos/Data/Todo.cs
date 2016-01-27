using System;
using System.ComponentModel.DataAnnotations;
using Task02_Todos.Data;

namespace Task02_Todos.Data
{ 
    public class Todo
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Body { get; set; }

        public DateTime DateChanged { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}