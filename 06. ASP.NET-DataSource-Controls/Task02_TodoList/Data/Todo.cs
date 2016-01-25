using System;
using System.ComponentModel.DataAnnotations;

namespace Task02_TodoList.Data
{
    public class Todo
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Body { get; set; }

        public DateTime DateChanged { get; set; }
    }
}