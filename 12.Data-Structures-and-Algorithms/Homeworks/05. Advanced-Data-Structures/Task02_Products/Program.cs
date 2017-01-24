namespace Task02_Products
{
    using System;

    using Wintellect.PowerCollections;

    public class Program
    {
        private const int ProductCount = 500000;
        private const int SearchCount = 10000;

        public static void Main(string[] args)
        {
            var data = new OrderedBag<Product>();

            Console.WriteLine("Creating random products");
            for (int i = 0; i < ProductCount; i++)
            {
                data.Add(
                    new Product(
                        RandomGenerator.RandomString(RandomGenerator.RandomInt(1, 100)),
                        (double)(RandomGenerator.RandomInt(1, 100000)) / 100));
            }

            Console.WriteLine("Searching products");
            for (int i = 0; i < SearchCount; i++)
            {
                double minValue = RandomGenerator.RandomInt(1, 100);
                double maxValue = RandomGenerator.RandomInt((int)minValue, (int)minValue + 900);

                var range = data.Range(new Product("", minValue), true, new Product("", maxValue), true);
                Console.WriteLine("Search #" + i);

                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine("Item# " + j + " = " + range[j].Name);
                }
            }
        }
    }
}
