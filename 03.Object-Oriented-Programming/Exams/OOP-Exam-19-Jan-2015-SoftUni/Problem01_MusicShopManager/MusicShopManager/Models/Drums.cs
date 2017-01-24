// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Drums.cs" company="">
//   
// </copyright>
// <summary>
//   The drums.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The drums.
    /// </summary>
    internal class Drums : Instrument, IDrums
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drums"/> class.
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
        /// <param name="color">
        /// The color.
        /// </param>
        /// <param name="isElectronic">
        /// The is electronic.
        /// </param>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// </exception>
        public Drums(string make, string model, decimal price, string color, bool isElectronic, int width, int height)
            : base(make, model, price, color, isElectronic)
        {
            if (width < 0)
            {
                throw new InvalidOperationException("The width must be positive.");
            }

            if (height < 0)
            {
                throw new InvalidOperationException("The height must be positive.");
            }

            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        ///     Gets the width.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        public int Height { get; private set; }
    }
}