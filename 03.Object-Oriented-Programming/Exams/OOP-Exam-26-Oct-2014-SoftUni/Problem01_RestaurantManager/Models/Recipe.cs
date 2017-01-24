// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="">
//   
// </copyright>
// <summary>
//   The recipe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Models
{
    using System;

    using RestaurantManager.Interfaces;

    /// <summary>
    /// The recipe.
    /// </summary>
    internal abstract class Recipe : IRecipe
    {
        /// <summary>
        /// The calories.
        /// </summary>
        private readonly int calories;

        /// <summary>
        /// The name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The price.
        /// </summary>
        private readonly decimal price;

        /// <summary>
        /// The quantity per serving.
        /// </summary>
        private readonly int quantityPerServing;

        /// <summary>
        /// The time to prepare.
        /// </summary>
        private readonly int timeToPrepare;

        /// <summary>
        /// The unit.
        /// </summary>
        private readonly MetricUnit unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe"/> class.
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
        /// <param name="unit">
        /// The unit.
        /// </param>
        /// <param name="time">
        /// The time.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        protected Recipe(string name, decimal price, int calories, int quantity, MetricUnit unit, int time)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name is required.");
            }

            if (price < 0 || calories < 0 || quantity < 0 || time < 0)
            {
                throw new InvalidOperationException("The <parameter> must be positive.");
            }

            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantity;
            this.unit = unit;
            this.timeToPrepare = time;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        /// <summary>
        /// Gets the calories.
        /// </summary>
        public int Calories
        {
            get
            {
                return this.calories;
            }
        }

        /// <summary>
        /// Gets the quantity per serving.
        /// </summary>
        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
        }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }
        }

        /// <summary>
        /// Gets the time to prepare.
        /// </summary>
        public int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
        }
    }
}