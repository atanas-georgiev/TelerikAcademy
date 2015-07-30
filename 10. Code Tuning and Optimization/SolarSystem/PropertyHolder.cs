// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyHolder.cs" company="">
//   
// </copyright>
// <summary>
//   The property holder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Surfaces
{
    using System.Windows;

    /// <summary>
    /// The property holder.
    /// </summary>
    /// <typeparam name="PropertyType">
    /// </typeparam>
    /// <typeparam name="HoldingType">
    /// </typeparam>
    public class PropertyHolder<PropertyType, HoldingType>
        where HoldingType : DependencyObject
    {
        /// <summary>
        /// The _property.
        /// </summary>
        private readonly DependencyProperty _property;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyHolder{PropertyType,HoldingType}"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="defaultValue">
        /// The default value.
        /// </param>
        /// <param name="propertyChangedCallback">
        /// The property changed callback.
        /// </param>
        public PropertyHolder(string name, PropertyType defaultValue, PropertyChangedCallback propertyChangedCallback)
        {
            this._property = DependencyProperty.Register(
                name, 
                typeof(PropertyType), 
                typeof(HoldingType), 
                new PropertyMetadata(defaultValue, propertyChangedCallback));
        }

        /// <summary>
        /// Gets the property.
        /// </summary>
        public DependencyProperty Property
        {
            get
            {
                return this._property;
            }
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="PropertyType"/>.
        /// </returns>
        public PropertyType Get(HoldingType obj)
        {
            return (PropertyType)obj.GetValue(this._property);
        }

        /// <summary>
        /// The set.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Set(HoldingType obj, PropertyType value)
        {
            obj.SetValue(this._property, value);
        }
    }
}