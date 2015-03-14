using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciplesPart1
{
    class Teacher : Person, IComment
    {
        public string Comment { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public Teacher() { }

    }
}
