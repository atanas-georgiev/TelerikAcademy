# Creational Design Patterns Homework

## Factory method pattern

### Мотивация
Factory Method дефинира интерфейс за създаване на обекти, но оставя на подкласовете да решат от кои класове да направят инстанции.

### Цел
Фабриката има за цел инстанцирането на различни обекти, чиито типове не са предефинирани. Обектите се създават динамично в зависимост от параметрите предадени на фабриката.

### Имплементация 

```cs 
static class Program
{
    static void Main()
    {
        FactoryBase factory = new ConcreteFactory();
        ProductBase product = factory.FactoryMethod(1);
        product.ShowInfo();
        product = factory.FactoryMethod(2);
        product.ShowInfo();
    }
}

public abstract class FactoryBase
{
    public abstract ProductBase FactoryMethod(int type);
}

public class ConcreteFactory : FactoryBase
{
    public override ProductBase FactoryMethod(int type)
    {
        switch (type)
        {
            case 1:
                return new ConcreteProduct1();
            case 2:
                return new ConcreteProduct2();
            default:
                throw new ArgumentException("Invalid type.", "type");
        }
    }
}


public abstract class ProductBase
{
    public abstract void ShowInfo();
}

public class ConcreteProduct1 : ProductBase {
    public override void ShowInfo()
    {
        Console.WriteLine("Product1");
    }
}

public class ConcreteProduct2 : ProductBase {
    public override void ShowInfo()
    {
        Console.WriteLine("Product2");
    }
}
```

### Последствия
Abstract Factory Pattern-ът се използва при системи, които често се изменят. Предоставя лесен и гъвкъв механизъм за замяна на конкретни групи от обекти.

### Структура
![FactoryMethod](images/Factory_Method.jpg.jpg "FactoryMethod - UML diagram")

### Сродни модели
* Simple Factory
* Abstract Factory
