using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat() { }
        public Cat(string name, int age, SexType gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Mau mau!!");
        }

        public override string ToString()
        {
            return String.Format("Cat name {0}, age {1}, sex {2}", base.Name, base.Age, base.Sex);
        }
    }
}
