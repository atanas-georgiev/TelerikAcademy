// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The category class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;

    /// <summary>
    ///     The category class.
    /// </summary>
    internal class Category : ICategory
    {
        /// <summary>
        ///     The max name length.
        /// </summary>
        private const int MaxNameLength = 15;

        /// <summary>
        ///     The min name length.
        /// </summary>
        private const int MinNameLength = 2;

        /// <summary>
        ///     The products.
        /// </summary>
        private readonly List<IProduct> products;

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Invalid values
        /// </exception>
        public Category(string name)
        {
            if (name.Length < MinNameLength || name.Length > MaxNameLength)
            {
                throw new ArgumentException(
                    string.Format(
                        "Category name must be between {0} and {1} symbols long!", 
                        MinNameLength, 
                        MaxNameLength));
            }

            this.Name = name;
            this.products = new List<IProduct>();
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The add cosmetics.
        /// </summary>
        /// <param name="cosmetics">
        /// The cosmetics.
        /// </param>
        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        /// <summary>
        /// The remove cosmetics.
        /// </summary>
        /// <param name="cosmetics">
        /// The cosmetics.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Element cannot be found
        /// </exception>
        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
            {
                throw new InvalidOperationException(
                    string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        /// <summary>
        ///     The print.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string Print()
        {
            var result = new StringBuilder();

            result.AppendFormat(
                "{0} category - {1} {2} in total", 
                this.Name, 
                this.products.Count, 
                this.products.Count == 1 ? "product" : "products");

            if (this.products.Any())
            {
                result.AppendLine();
            }

            result.Append(
                string.Join(Environment.NewLine, this.products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price)));

            return result.ToString();
        }
    }
}