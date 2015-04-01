// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dessert.cs" company="">
//   
// </copyright>
// <summary>
//   The dessert.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;

    /// <summary>
    /// The dessert.
    /// </summary>
    internal class Dessert : Meal, IDessert
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dessert"/> class.
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
        /// <param name="isVegan">
        /// The is vegan.
        /// </param>
        /// <param name="withSugar">
        /// The with sugar.
        /// </param>
        public Dessert(string name, decimal price, int calories, int quantity, int time, bool isVegan, bool withSugar)
            : base(name, price, calories, quantity, time, isVegan)
        {
            this.WithSugar = withSugar;
        }

        /// <summary>
        /// Gets a value indicating whether with sugar.
        /// </summary>
        public bool WithSugar { get; private set; }

        /// <summary>
        /// The toggle sugar.
        /// </summary>
        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }
    }
}