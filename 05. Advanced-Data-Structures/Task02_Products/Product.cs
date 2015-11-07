namespace Task02_Products
{
    using System;

    public class Product : IComparable
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CompareTo(object obj)
        {
            var product = obj as Product;
            if (product != null)
            {
                return (int)(this.Price - product.Price);
            }

            return -1;
        }
    }
}
