// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Chef.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The chef.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task01ClassChef
{
    using System.Collections.Generic;

    using Bowl = System.Int32;
    using Carrot = System.Int32;
    using Potato = System.Int32;
    using Vegetable = System.Int32;

    /// <summary>
    ///     The chef.
    /// </summary>
    internal class Chef
    {
        /// <summary>
        ///     The cook.
        /// </summary>
        public void Cook()
        {
            var potato = this.GetPotato();
            var carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            var bowl = this.GetBowl();

            // bowl.Add(carrot);
            // bowl.Add(potato);
        }

        /// <summary>
        /// The peel.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        private void Peel(int value)
        {
        }

        /// <summary>
        ///     The get bowl.
        /// </summary>
        /// <returns>
        ///     The <see cref="List{T}" />.
        /// </returns>
        private int GetBowl()
        {
            // ... 
            return 0;
        }

        /// <summary>
        ///     The get carrot.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        private int GetCarrot()
        {
            // ...
            return 0;
        }

        /// <summary>
        /// The cut.
        /// </summary>
        /// <param name="potato">
        /// The potato.
        /// </param>
        private void Cut(int potato)
        {
            // ...            
        }

        /// <summary>
        ///     The get potato.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        private int GetPotato()
        {
            // ...
            return 0;
        }
    }
}