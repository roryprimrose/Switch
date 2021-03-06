﻿namespace Neovolve.Switch.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The <see cref="VisibleContentConverter"/>
    ///   class is used to return a visibility value based on whether a value is available.
    /// </summary>
    internal class VisibleContentConverter : IValueConverter
    {
        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">
        /// The value produced by the binding source.
        /// </param>
        /// <param name="targetType">
        /// The type of the binding target property.
        /// </param>
        /// <param name="parameter">
        /// The converter parameter to use.
        /// </param>
        /// <param name="culture">
        /// The culture to use in the converter.
        /// </param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            String stringValue = value as String;

            if (stringValue != null)
            {
                if (String.IsNullOrWhiteSpace(stringValue))
                {
                    return Visibility.Collapsed;
                }

                return Visibility.Visible;
            }

            if (value == null)
            {
                return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">
        /// The value that is produced by the binding target.
        /// </param>
        /// <param name="targetType">
        /// The type to convert to.
        /// </param>
        /// <param name="parameter">
        /// The converter parameter to use.
        /// </param>
        /// <param name="culture">
        /// The culture to use in the converter.
        /// </param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}