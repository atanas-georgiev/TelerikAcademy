// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BassGuitar.cs" company="">
//   
// </copyright>
// <summary>
//   The bass guitar.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The bass guitar.
    /// </summary>
    internal class BassGuitar : Guitar, IBassGuitar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BassGuitar"/> class.
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
        public BassGuitar(
            string make, 
            string model, 
            decimal price, 
            string color, 
            bool isElectronic, 
            string bodyWood, 
            string fingerboardWood, 
            int stringsNum)
            : base(make, model, price, color, isElectronic, bodyWood, fingerboardWood, stringsNum)
        {
        }
    }
}