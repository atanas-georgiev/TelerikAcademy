// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The circle.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    ///     The circle.
    /// </summary>
    internal class Circle : Figure
    {
        /// <summary>
        ///     The radius.
        /// </summary>
        private double radius;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.Radius = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">
        /// The radius.
        /// </param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        ///     Gets or sets the radius.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Negative value
        /// </exception>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius must be positive number!");
                }

                this.radius = value;
            }
        }

        /// <summary>
        ///     Calculate perimeter.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public override double CalcPerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        ///     Calculate surface.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public override double CalcSurface()
        {
            var surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                "I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", 
                this.CalcPerimeter(), 
                this.CalcSurface());
        }
    }
}