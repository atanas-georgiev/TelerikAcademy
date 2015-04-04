// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Instrument.cs" company="">
//   
// </copyright>
// <summary>
//   The instrument.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The instrument.
    /// </summary>
    internal abstract class Instrument : Article, IInstrument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument"/> class.
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
        public Instrument(string make, string model, decimal price, string color, bool isElectronic)
            : base(make, model, price)
        {
            if (string.IsNullOrEmpty(color))
            {
                throw new ArgumentException("The color is required.");
            }

            this.Color = color;
            this.IsElectronic = isElectronic;
        }

        /// <summary>
        ///     Gets the color.
        /// </summary>
        public string Color { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether is electronic.
        /// </summary>
        public bool IsElectronic { get; private set; }
    }
}