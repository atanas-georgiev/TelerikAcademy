// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AcousticGuitar.cs" company="">
//   
// </copyright>
// <summary>
//   The acoustic guitar.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;
    using MusicShopManager.Models;

    /// <summary>
    ///     The acoustic guitar.
    /// </summary>
    internal class AcousticGuitar : Guitar, IAcousticGuitar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcousticGuitar"/> class.
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
        /// <param name="caseIncluded">
        /// The case included.
        /// </param>
        /// <param name="stringMaterial">
        /// The string material.
        /// </param>
        public AcousticGuitar(
            string make, 
            string model, 
            decimal price, 
            string color, 
            bool isElectronic, 
            string bodyWood, 
            string fingerboardWood, 
            int stringsNum, 
            bool caseIncluded, 
            StringMaterial stringMaterial)
            : base(make, model, price, color, isElectronic, bodyWood, fingerboardWood, stringsNum)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        /// <summary>
        ///     Gets a value indicating whether case included.
        /// </summary>
        public bool CaseIncluded { get; private set; }

        /// <summary>
        ///     Gets the string material.
        /// </summary>
        public StringMaterial StringMaterial { get; private set; }
    }
}