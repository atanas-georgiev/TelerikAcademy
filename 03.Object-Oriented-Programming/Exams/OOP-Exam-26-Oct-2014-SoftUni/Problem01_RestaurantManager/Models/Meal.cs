// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Meal.cs" company="">
//   
// </copyright>
// <summary>
//   The meal.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;

    /// <summary>
    /// The meal.
    /// </summary>
    internal abstract class Meal : Recipe, IMeal
    {
        /// <summary>
        /// The is vegan.
        /// </summary>
        private bool isVegan;

        /// <summary>
        /// Initializes a new instance of the <see cref="Meal"/> class.
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
        /// <param name="isVegan">
        /// The is vegan.
        /// </param>
        protected Meal(string name, decimal price, int calories, int quantity, int time, bool isVegan)
            : base(name, price, calories, quantity, MetricUnit.Grams, time)
        {
            this.isVegan = isVegan;
        }

        /// <summary>
        /// Gets a value indicating whether is vegan.
        /// </summary>
        public bool IsVegan
        {
            get
            {
                return this.isVegan;
            }
        }

        /// <summary>
        /// The toggle vegan.
        /// </summary>
        public void ToggleVegan()
        {
            this.isVegan = !this.isVegan;
        }
    }
}