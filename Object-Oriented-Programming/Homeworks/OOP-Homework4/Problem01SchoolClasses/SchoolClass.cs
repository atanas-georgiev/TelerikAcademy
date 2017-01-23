using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciplesPart1
{
    class SchoolClass : IComment
    {
        public string Comment { get; set; }
        public int Identifier { get; set; }
        public List<Teacher> Teachers { get; set; }
        public SchoolClass() { }
    }
}
