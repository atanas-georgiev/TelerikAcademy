using System;
using System.ComponentModel.DataAnnotations;

namespace Task02_Todos.Data
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }        
    }
}