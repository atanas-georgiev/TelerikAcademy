//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03AnimalHierarchy
{
    class MainProgram
    {
        static double AverageAgeOfAFind(List<Animal> animals, Type Classname)
        {
            double sum = (from animal in animals
                       where animal.GetType() == Classname
                       select animal.Age).Sum();
            double number = (from animal in animals
                          where animal.GetType() == Classname
                          select animal).Count();
            return sum / number;
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Frog("Froggy", 1, Animal.SexType.Male));
            animals.Add(new Frog("Zelenka", 2, Animal.SexType.Female));
            animals.Add(new Dog("Sharo", 4, Animal.SexType.Male));
            animals.Add(new Dog("Balkan", 7, Animal.SexType.Male));
            animals.Add(new Cat("Misho", 2, Animal.SexType.Male));
            animals.Add(new Kitten("Masha", 1));
            animals.Add(new Tomcat("Tom", 4));

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Average age of frogs is " + AverageAgeOfAFind(animals, typeof(Frog)));
            Console.WriteLine("Average age of dogs is " + AverageAgeOfAFind(animals, typeof(Dog)));
            Console.WriteLine("Average age of cats is " + AverageAgeOfAFind(animals, typeof(Cat)));
            Console.WriteLine("Average age of kittens is " + AverageAgeOfAFind(animals, typeof(Kitten)));
            Console.WriteLine("Average age of tomcats is " + AverageAgeOfAFind(animals, typeof(Tomcat)));
        }
    }
}
