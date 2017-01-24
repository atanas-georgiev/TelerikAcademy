using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, string town, ITeacher teacher = null)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town { get; set; }

        public override string ToString()
        {            
            StringBuilder res = new StringBuilder();
            if (this.Teacher != null)
            {
                res.Append(String.Format("OffsiteCourse: Name={0}; Teacher={1};", this.Name, this.Teacher.Name));
            }
            else
            {
                res.Append(String.Format("OffsiteCourse: Name={0};", this.Name));
            }           

            if (topics.Count > 0)
            {
                res.Append(" Topics=[");

                foreach (var item in topics)
                {
                    res.Append(item + ", ");
                }

                return res.ToString().TrimEnd(' ').TrimEnd(',') + "]; Town=" + this.Town;
            }

            return res.ToString() + " Lab=" + this.Town;
        }
    }
}