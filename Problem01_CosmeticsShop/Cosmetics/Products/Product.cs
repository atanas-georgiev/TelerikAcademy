// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The product class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Cosmetics.Products
{
    using System;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    /// <summary>
    ///     The product class.
    /// </summary>
    internal abstract class Product : IProduct
    {
        /// <summary>
        /// The min name length.
        /// </summary>
        private const int MinNameLength = 3;

        /// <summary>
        /// The max name length.
        /// </summary>
        private const int MaxNameLength = 10;

        /// <summary>
        /// The min brand length.
        /// </summary>
        private const int MinBrandLength = 2;

        /// <summary>
        /// The max brand length.
        /// </summary>
        private const int MaxBrandLength = 10;

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of the product.
        /// </param>
        /// <param name="brand">
        /// The brand of the product.
        /// </param>
        /// <param name="price">
        /// The price of the product.
        /// </param>
        /// <param name="gender">
        /// The gender of the product.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Invalid input values
        /// </exception>
        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            if (name.Length < MinNameLength || name.Length > MaxNameLength)
            {
                throw new ArgumentException(
                    string.Format(
                        "Product name must be between {0} and {1} symbols long!", 
                        MinNameLength, 
                        MaxNameLength));
            }

            if (brand.Length < MinBrandLength || brand.Length > MaxBrandLength)
            {
                throw new ArgumentException(
                    string.Format(
                        "Product brand must be between {0} and {1} symbols long!", 
                        MinBrandLength, 
                        MaxBrandLength));
            }

            if (price < 0)
            {
                throw new ArgumentException("Price must be more than 0!");
            }

            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the brand.
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        ///     Gets the price.
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        ///     Gets the gender.
        /// </summary>
        public GenderType Gender { get; private set; }

        /// <summary>
        ///     Print result.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string Print()
        {
            return this.ToString();
        }
    }
}