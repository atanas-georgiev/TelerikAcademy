// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainCourse.cs" company="">
//   
// </copyright>
// <summary>
//   The main course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;

    /// <summary>
    /// The main course.
    /// </summary>
    internal class MainCourse : Meal, IMainCourse
    {
        /// <summary>
        /// The type.
        /// </summary>
        private readonly MainCourseType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainCourse"/> class.
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
        /// <param name="type">
        /// The type.
        /// </param>
        public MainCourse(
            string name, 
            decimal price, 
            int calories, 
            int quantity, 
            int time, 
            bool isVegan, 
            MainCourseType type)
            : base(name, price, calories, quantity, time, isVegan)
        {
            this.type = type;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public MainCourseType Type
        {
            get
            {
                return this.type;
            }
        }
    }
}