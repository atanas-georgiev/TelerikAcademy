// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Salad.cs" company="">
//   
// </copyright>
// <summary>
//   The salad.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;

    /// <summary>
    /// The salad.
    /// </summary>
    internal class Salad : Meal, ISalad
    {
        /// <summary>
        /// The contains pasta.
        /// </summary>
        private readonly bool containsPasta;

        /// <summary>
        /// Initializes a new instance of the <see cref="Salad"/> class.
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
        /// <param name="containsPasta">
        /// The contains pasta.
        /// </param>
        public Salad(
            string name, 
            decimal price, 
            int calories, 
            int quantity, 
            int time, 
            bool isVegan, 
            bool containsPasta)
            : base(name, price, calories, quantity, time, isVegan)
        {
            this.containsPasta = containsPasta;
        }

        /// <summary>
        /// Gets a value indicating whether contains pasta.
        /// </summary>
        public bool ContainsPasta
        {
            get
            {
                return this.containsPasta;
            }
        }
    }
}