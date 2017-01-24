// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Guitar.cs" company="">
//   
// </copyright>
// <summary>
//   The guitar.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The guitar.
    /// </summary>
    internal abstract class Guitar : Instrument, IGuitar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Guitar"/> class.
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
        /// <param name="bodyWood">
        /// The body wood.
        /// </param>
        /// <param name="fingerboardWood">
        /// The fingerboard wood.
        /// </param>
        /// <param name="stringsNum">
        /// The strings num.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// </exception>
        public Guitar(
            string make, 
            string model, 
            decimal price, 
            string color, 
            bool isElectronic, 
            string bodyWood, 
            string fingerboardWood, 
            int stringsNum)
            : base(make, model, price, color, isElectronic)
        {
            if (string.IsNullOrEmpty(bodyWood))
            {
                throw new ArgumentException("The bodyWood is required.");
            }

            if (string.IsNullOrEmpty(fingerboardWood))
            {
                throw new ArgumentException("The fingerboardWood is required.");
            }

            if (stringsNum < 0 || stringsNum > 6)
            {
                throw new InvalidOperationException("The strings number must be positive and not more than six.");
            }

            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = stringsNum;
        }

        /// <summary>
        ///     Gets the body wood.
        /// </summary>
        public string BodyWood { get; private set; }

        /// <summary>
        ///     Gets the fingerboard wood.
        /// </summary>
        public string FingerboardWood { get; private set; }

        /// <summary>
        ///     Gets the number of strings.
        /// </summary>
        public int NumberOfStrings { get; private set; }
    }
}