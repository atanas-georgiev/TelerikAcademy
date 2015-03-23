using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class Teacher : ITeacher
    {
        private List<ICourse> courses = new List<ICourse>();

        public Teacher(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Teacher: Name={0}", this.Name));

            if (courses.Count > 0)
            {
                res.Append("; Courses=[");
            
                foreach (var item in courses)
                {
                    res.Append(item.Name + ", ");
                }

                return res.ToString().TrimEnd(' ').TrimEnd(',') + "]";
            }

            return res.ToString();           
        }
    }
}
