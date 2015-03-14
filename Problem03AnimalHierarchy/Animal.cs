using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    abstract class Animal : ISound
    {
        public enum SexType { Male, Female }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual SexType Sex { get; set; }

        public Animal() { }
        public Animal(string name, int age, SexType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = gender;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Not specified sound from animal -> GRRRRRRRRRRRRRRRRRRR");
        }
        
    }
}
