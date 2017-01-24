// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricGuitar.cs" company="">
//   
// </copyright>
// <summary>
//   The electric guitar.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The electric guitar.
    /// </summary>
    internal class ElectricGuitar : Guitar, IElectricGuitar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricGuitar"/> class.
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
        /// <param name="numberOfAdapters">
        /// The number of adapters.
        /// </param>
        /// <param name="numberOfFrets">
        /// The number of frets.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// </exception>
        public ElectricGuitar(
            string make, 
            string model, 
            decimal price, 
            string color, 
            bool isElectronic, 
            string bodyWood, 
            string fingerboardWood, 
            int stringsNum, 
            int numberOfAdapters, 
            int numberOfFrets)
            : base(make, model, price, color, isElectronic, bodyWood, fingerboardWood, stringsNum)
        {
            if (numberOfAdapters < 0)
            {
                throw new InvalidOperationException("The numberOfAdapters must be positive.");
            }

            if (numberOfFrets < 0)
            {
                throw new InvalidOperationException("The numberOfFrets must be positive.");
            }

            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        /// <summary>
        ///     Gets the number of adapters.
        /// </summary>
        public int NumberOfAdapters { get; private set; }

        /// <summary>
        ///     Gets the number of frets.
        /// </summary>
        public int NumberOfFrets { get; private set; }
    }
}