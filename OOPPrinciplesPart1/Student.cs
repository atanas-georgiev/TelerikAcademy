using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciplesPart1
{
    class Student : Person, IComment
    {
        public string Comment { get; set; }
        public int ClassNumber { get; set; }
        public Student() { }
    }
}
