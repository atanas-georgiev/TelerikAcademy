// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCart.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The shopping cart.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cosmetics.Products
{
    using System.Collections.Generic;

    using Cosmetics.Contracts;

    /// <summary>
    /// The shopping cart.
    /// </summary>
    internal class ShoppingCart : IShoppingCart
    {
        /// <summary>
        /// The products.
        /// </summary>
        private readonly List<IProduct> products;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart"/> class.
        /// </summary>
        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        /// <summary>
        /// The add product.
        /// </summary>
        /// <param name="product">
        /// The product.
        /// </param>
        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        /// <summary>
        /// The remove product.
        /// </summary>
        /// <param name="product">
        /// The product.
        /// </param>
        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        /// <summary>
        /// The contains product.
        /// </summary>
        /// <param name="product">
        /// The product.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        /// <summary>
        /// The total price.
        /// </summary>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        public decimal TotalPrice()
        {
            decimal res = 0;
            foreach (var product in this.products)
            {
                if (product is IShampoo)
                {
                    res += (product as IShampoo).Milliliters * product.Price;
                }
                else
                {
                    res += product.Price;
                }
            }

            return res;
        }
    }
}