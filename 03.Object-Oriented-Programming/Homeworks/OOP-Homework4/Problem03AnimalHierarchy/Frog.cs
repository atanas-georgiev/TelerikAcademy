using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog() { }
        public Frog(string name, int age, SexType gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Dzhvak Dzhvak!!");
        }

        public override string ToString()
        {
            return String.Format("Frog name {0}, age {1}, sex {2}", base.Name, base.Age, base.Sex);
        }
    }
}
