# Creational Design Patterns Homework

## Prototype pattern

### Мотивация
Служи за клониране на вече създадени обекти. Използва се, когато създаването на нов обект(копие) използва много повече ресурси, отколкото, ако го клонираме, както и при класове, които се инстанцират по време на изпълнение на програмата

### Цел

Създава нови обекти като клонира вече създадени такива.

### Имплементация 

```cs 
using System;

namespace PrototypeExample
{
  class MainApp
  {
    static void Main()
    {
      // Create two instances and clone each

      ConcretePrototype1 p1 = new ConcretePrototype1("I");
      ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
      Console.WriteLine("Cloned: {0}", c1.Id);

      ConcretePrototype2 p2 = new ConcretePrototype2("II");
      ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
      Console.WriteLine("Cloned: {0}", c2.Id);

      // Wait for user
      Console.ReadKey();
    }
  }

  abstract class Prototype
  {
    private string _id;

    public Prototype(string id)
    {
      this._id = id;
    }

    // Gets id
    public string Id
    {
      get { return _id; }
    }

    public abstract Prototype Clone();
  }

  class ConcretePrototype1 : Prototype
  {
    public ConcretePrototype1(string id)
      : base(id)
    {
    }

    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }

  class ConcretePrototype2 : Prototype
  {

    public ConcretePrototype2(string id)
      : base(id)
    {
    }

    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }
}
```

### Последствия
* Спестява използвани ресурси.
* Улеснява значително създаването на нови обекти

### Структура
![Prototype](images/Prototype.jpg "Prototype - UML diagram")

### Сродни модели
* Factory method
* Abstract Factory

### Проблеми
* Използването на този шаблон изисква всички класове, които трябва да бъдат копирани да наследяват ICloneable(ако ползваме вградения в .NET интерфейс) или да имат свой собствен метод Clone(). В случаите, когато това не е изпълнено, клонирането става по-трудно.
* Трябва да се внимава при имлементирането на методите, защото методът 'MemberwiseClone()'(когато става въпрос за референтни типове) копира референцията им, което води до създаването на 'shallow copy'.