namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(20)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}

