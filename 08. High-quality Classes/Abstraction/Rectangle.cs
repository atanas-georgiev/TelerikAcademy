// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The rectangle.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    ///     The rectangle.
    /// </summary>
    internal class Rectangle : Figure
    {
        /// <summary>
        ///     The height.
        /// </summary>
        private double height;

        /// <summary>
        ///     The width.
        /// </summary>
        private double width;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        public Rectangle()
        {
            this.Width = 0;
            this.Height = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        ///     Gets or sets the width.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Negative value
        /// </exception>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be positive number!");
                }

                this.width = value;
            }
        }

        /// <summary>
        ///     Gets or sets the height.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Negative value
        /// </exception>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be positive number!");
                }

                this.height = value;
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
            var perimeter = 2 * (this.Width + this.Height);
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
            var surface = this.Width * this.Height;
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
                "I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", 
                this.CalcPerimeter(), 
                this.CalcSurface());
        }
    }
}