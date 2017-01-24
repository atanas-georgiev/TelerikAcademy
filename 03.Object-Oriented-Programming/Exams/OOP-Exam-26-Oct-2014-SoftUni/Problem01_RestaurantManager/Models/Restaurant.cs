// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Restaurant.cs" company="">
//   
// </copyright>
// <summary>
//   The restaurant.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using RestaurantManager.Interfaces;

    /// <summary>
    ///     The restaurant.
    /// </summary>
    public class Restaurant : IRestaurant
    {
        /// <summary>
        ///     The location.
        /// </summary>
        private readonly string location;

        /// <summary>
        ///     The name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Restaurant"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public Restaurant(string name, string location)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name is required");
            }

            if (string.IsNullOrEmpty(location))
            {
                throw new ArgumentException("The location is required");
            }

            this.name = name;
            this.location = location;
            this.Recipes = new List<IRecipe>();
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        ///     Gets the location.
        /// </summary>
        public string Location
        {
            get
            {
                return this.location;
            }
        }

        /// <summary>
        ///     Gets the recipes.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IList<IRecipe> Recipes { get; private set; }

        /// <summary>
        /// The add recipe.
        /// </summary>
        /// <param name="recipe">
        /// The recipe.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        /// <summary>
        /// The remove recipe.
        /// </summary>
        /// <param name="recipe">
        /// The recipe.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        /// <summary>
        ///     The print menu.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string PrintMenu()
        {
            var result = new StringBuilder();
            result.AppendFormat("***** {0} - {1} *****", this.Name, this.Location);
            if (!this.Recipes.Any())
            {
                result.AppendLine().Append("No recipes... yet");
            }
            else
            {
                var drinks = this.Recipes.Where(x => x is IDrink).OrderBy(x => x.Name);
                if (drinks.Any())
                {
                    result.AppendLine().Append("~~~~~ DRINKS ~~~~~");

                    foreach (IDrink item in drinks)
                    {
                        result.AppendLine().AppendFormat("==  {0} == ${1:0.00}", item.Name, item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} ml, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Carbonated: {0}", item.IsCarbonated ? "yes" : "no");
                    }
                }

                var salads = this.Recipes.Where(x => x is ISalad).OrderBy(x => x.Name);
                if (salads.Any())
                {
                    result.AppendLine().Append("~~~~~ SALADS ~~~~~");

                    foreach (ISalad item in salads)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}==  {1} == ${2:0.00}",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Contains pasta: {0}", item.ContainsPasta ? "yes" : "no");
                    }
                }

                var mainCourses = this.Recipes.Where(x => x is IMainCourse).OrderBy(x => x.Name);
                if (mainCourses.Any())
                {
                    result.AppendLine().Append("~~~~~ MAIN COURSES ~~~~~");

                    foreach (IMainCourse item in mainCourses)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}==  {1} == ${2:0.00}",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Type: {0}", item.Type.ToString());
                    }
                }

                var desserts = this.Recipes.Where(x => x is IDessert).OrderBy(x => x.Name);
                if (desserts.Any())
                {
                    result.AppendLine().Append("~~~~~ DESSERTS ~~~~~");

                    foreach (IDessert item in desserts)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}{1}==  {2} == ${3:0.00}",
                                item.WithSugar ? string.Empty : "[NO SUGAR] ",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                    }
                }
            }

            return result.ToString();
        }
    }
}