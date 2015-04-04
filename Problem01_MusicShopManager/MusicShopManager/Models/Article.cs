// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Article.cs" company="">
//   
// </copyright>
// <summary>
//   The article.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The article.
    /// </summary>
    internal abstract class Article : IArticle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Article"/> class.
        /// </summary>
        /// <param name="make">
        /// The make.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// </exception>
        public Article(string make, string model, decimal price)
        {
            if (string.IsNullOrEmpty(make))
            {
                throw new ArgumentException("The make is required.");
            }

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("The model is required.");
            }

            if (price < 0)
            {
                throw new InvalidOperationException("The price must be positive.");
            }

            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        /// <summary>
        ///     Gets the make.
        /// </summary>
        public string Make { get; private set; }

        /// <summary>
        ///     Gets the model.
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        ///     Gets the price.
        /// </summary>
        public decimal Price { get; private set; }
    }
}