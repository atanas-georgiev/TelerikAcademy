// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Microphone.cs" company="">
//   
// </copyright>
// <summary>
//   The microphone.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The microphone.
    /// </summary>
    internal class Microphone : Article, IMicrophone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microphone"/> class.
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
        /// <param name="hasCable">
        /// The has cable.
        /// </param>
        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }

        /// <summary>
        ///     Gets a value indicating whether has cable.
        /// </summary>
        public bool HasCable { get; private set; }
    }
}