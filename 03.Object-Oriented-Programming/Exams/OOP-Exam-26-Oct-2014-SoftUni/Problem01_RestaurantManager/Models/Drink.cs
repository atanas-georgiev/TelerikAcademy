// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Drink.cs" company="">
//   
// </copyright>
// <summary>
//   The drink.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RestaurantManager.Models
{
    using System;

    using RestaurantManager.Interfaces;

    /// <summary>
    ///     The drink.
    /// </summary>
    internal class Drink : Recipe, IDrink
    {
        /// <summary>
        /// The is carbonated.
        /// </summary>
        private readonly bool isCarbonated;

        /// <summary>
        /// Initializes a new instance of the <see cref="Drink"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="calories">
        /// The calories.
        /// </param>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <param name="time">
        /// The time.
        /// </param>
        /// <param name="isCarbonated">
        /// The is carbonated.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// </exception>
        public Drink(string name, decimal price, int calories, int quantity, int time, bool isCarbonated)
            : base(name, price, calories, quantity, MetricUnit.Milliliters, time)
        {
            if (calories > 100)
            {
                throw new ArgumentException("Calories should not be more than 100.");
            }

            if (time > 20)
            {
                throw new InvalidOperationException("Too long to prepare.");
            }

            this.isCarbonated = isCarbonated;
        }

        /// <summary>
        /// Gets a value indicating whether is carbonated.
        /// </summary>
        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }
        }
    }
}