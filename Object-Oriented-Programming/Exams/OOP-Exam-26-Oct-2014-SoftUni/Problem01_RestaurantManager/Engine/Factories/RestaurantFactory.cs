// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RestaurantFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The restaurant factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Engine.Factories
{
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Models;

    /// <summary>
    /// The restaurant factory.
    /// </summary>
    public class RestaurantFactory : IRestaurantFactory
    {
        /// <summary>
        /// The create restaurant.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <returns>
        /// The <see cref="IRestaurant"/>.
        /// </returns>
        public IRestaurant CreateRestaurant(string name, string location)
        {
            return new Restaurant(name, location);
        }
    }
}