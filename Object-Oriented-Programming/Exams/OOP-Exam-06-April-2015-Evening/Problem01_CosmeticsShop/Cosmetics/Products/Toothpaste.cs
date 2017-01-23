// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Toothpaste.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The toothpaste class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    /// <summary>
    ///     The toothpaste class.
    /// </summary>
    internal class Toothpaste : Product, IToothpaste
    {
        /// <summary>
        ///     The min ingredient length.
        /// </summary>
        private const int MinIngredientLength = 2;

        /// <summary>
        ///     The max ingredient length.
        /// </summary>
        private const int MaxIngredientLength = 12;

        /// <summary>
        /// Initializes a new instance of the <see cref="Toothpaste"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="brand">
        /// The brand.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="gender">
        /// The gender.
        /// </param>
        /// <param name="ingredients">
        /// The ingredients.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Invalid values
        /// </exception>
        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            if (
                ingredients.Any(
                    ingredient => ingredient.Length < MinIngredientLength || ingredient.Length > MaxIngredientLength))
            {
                throw new ArgumentException(
                    string.Format(
                        "Each ingredient must be between {0} and {1} symbols long!", 
                        MinIngredientLength, 
                        MaxIngredientLength));
            }

            this.Ingredients = string.Join(", ", ingredients);
        }

        /// <summary>
        ///     Gets the ingredients.
        /// </summary>
        public string Ingredients { get; private set; }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("- {0} - {1}:", this.Brand, this.Name).AppendLine();
            result.AppendFormat("  * Price: ${0}", this.Price).AppendLine();
            result.AppendFormat("  * For gender: {0}", this.Gender.ToString()).AppendLine();
            result.AppendFormat("  * Ingredients: {0}", this.Ingredients);
            return result.ToString();
        }
    }
}