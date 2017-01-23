// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecipeFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The recipe factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RestaurantManager.Engine.Factories
{
    using System;

    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Models;

    /// <summary>
    ///     The recipe factory.
    /// </summary>
    public class RecipeFactory : IRecipeFactory
    {
        /// <summary>
        /// The create drink.
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
        /// <param name="quantityPerServing">
        /// The quantity per serving.
        /// </param>
        /// <param name="timeToPrepare">
        /// The time to prepare.
        /// </param>
        /// <param name="isCarbonated">
        /// The is carbonated.
        /// </param>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        public IDrink CreateDrink(
            string name, 
            decimal price, 
            int calories, 
            int quantityPerServing, 
            int timeToPrepare, 
            bool isCarbonated)
        {
            return new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);
        }

        /// <summary>
        /// The create salad.
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
        /// <param name="quantityPerServing">
        /// The quantity per serving.
        /// </param>
        /// <param name="timeToPrepare">
        /// The time to prepare.
        /// </param>
        /// <param name="containsPasta">
        /// The contains pasta.
        /// </param>
        /// <returns>
        /// The <see cref="ISalad"/>.
        /// </returns>
        public ISalad CreateSalad(
            string name, 
            decimal price, 
            int calories, 
            int quantityPerServing, 
            int timeToPrepare, 
            bool containsPasta)
        {
            return new Salad(name, price, calories, quantityPerServing, timeToPrepare, true, containsPasta);
        }

        /// <summary>
        /// The create main course.
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
        /// <param name="quantityPerServing">
        /// The quantity per serving.
        /// </param>
        /// <param name="timeToPrepare">
        /// The time to prepare.
        /// </param>
        /// <param name="isVegan">
        /// The is vegan.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IMainCourse"/>.
        /// </returns>
        public IMainCourse CreateMainCourse(
            string name, 
            decimal price, 
            int calories, 
            int quantityPerServing, 
            int timeToPrepare, 
            bool isVegan, 
            string type)
        {
            return new MainCourse(
                name, 
                price, 
                calories, 
                quantityPerServing, 
                timeToPrepare, 
                isVegan, 
                (MainCourseType)Enum.Parse(typeof(MainCourseType), type));
        }

        /// <summary>
        /// The create dessert.
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
        /// <param name="quantityPerServing">
        /// The quantity per serving.
        /// </param>
        /// <param name="timeToPrepare">
        /// The time to prepare.
        /// </param>
        /// <param name="isVegan">
        /// The is vegan.
        /// </param>
        /// <returns>
        /// The <see cref="IDessert"/>.
        /// </returns>
        public IDessert CreateDessert(
            string name, 
            decimal price, 
            int calories, 
            int quantityPerServing, 
            int timeToPrepare, 
            bool isVegan)
        {
            return new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan, true);
        }
    }
}