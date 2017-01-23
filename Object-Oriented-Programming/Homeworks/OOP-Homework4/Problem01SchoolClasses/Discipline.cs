using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPPrinciplesPart1
{
    class Discipline : IComment
    {
        public string Comment { get; set; }
        public string Name { get; set; }
        public int NumberLectures { get; set; }
        public int NumberExercises { get; set; }

        public Discipline() { }
        public Discipline(string name, int nbrLectures, int nbrExercises)
            : this()
        {
            this.Name = name;
            this.NumberLectures = nbrLectures;
            this.NumberExercises = nbrExercises;
        }
    }
}
