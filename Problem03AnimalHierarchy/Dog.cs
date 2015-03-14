using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog() { }
        public Dog(string name, int age, SexType gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau Bau!!");
        }

        public override string ToString()
        {
            return String.Format("Dog name {0}, age {1}, sex {2}", base.Name, base.Age, base.Sex);
        }
    }
}
