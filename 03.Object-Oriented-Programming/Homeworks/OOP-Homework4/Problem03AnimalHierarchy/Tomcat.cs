using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat() { }
        public Tomcat(string name, int age)
            : base(name, age, SexType.Male)
        {

        }

        public override SexType Sex
        {
            get
            {
                return SexType.Male;
            }
            set
            {
                
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kit Kat tomcat :)!!");
        }

        public override string ToString()
        {
            return String.Format("Tomcat name {0}, age {1}, sex {2}", base.Name, base.Age, base.Sex);
        }
    }
}
