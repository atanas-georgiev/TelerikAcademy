using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten() { }
        public Kitten(string name, int age):base(name, age, SexType.Female)
        {
        
        }

        public override SexType Sex 
        { 
            get
            {
                return SexType.Female;
            }
            set
            {
               
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kit Kat :)!!");
        }

        public override string ToString()
        {
            return String.Format("Kitten name {0}, age {1}, sex {2}", base.Name, base.Age, base.Sex);
        }
    }
}
