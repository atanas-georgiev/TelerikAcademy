// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shampoo.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The shampoo class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    /// <summary>
    /// The shampoo class.
    /// </summary>
    internal class Shampoo : Product, IShampoo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shampoo"/> class.
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
        /// <param name="milliliters">
        /// The milliliters.
        /// </param>
        /// <param name="usage">
        /// The usage.
        /// </param>
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        /// <summary>
        /// Gets the milliliters.
        /// </summary>
        public uint Milliliters { get; private set; }

        /// <summary>
        /// Gets the usage.
        /// </summary>
        public UsageType Usage { get; private set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("- {0} - {1}:", this.Brand, this.Name).AppendLine();
            result.AppendFormat("  * Price: ${0}", this.Price * this.Milliliters).AppendLine();
            result.AppendFormat("  * For gender: {0}", this.Gender.ToString()).AppendLine();
            result.AppendFormat("  * Quantity: {0} ml", this.Milliliters).AppendLine();
            result.AppendFormat("  * Usage: {0}", this.Usage.ToString());
            return result.ToString();
        }
    }
}