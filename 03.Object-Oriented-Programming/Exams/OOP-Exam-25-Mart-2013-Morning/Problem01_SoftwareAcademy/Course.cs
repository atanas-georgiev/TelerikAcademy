using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class Course : ICourse
    {
        protected List<string> topics = new List<string>();
        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }
    }
}
