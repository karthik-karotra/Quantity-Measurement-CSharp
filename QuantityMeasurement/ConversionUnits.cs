// <copyright file="ConversionUnits.cs" company="BridgeLabz Solutions">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurement
{
    /// <summary>
    /// Conversion Units Class.
    /// </summary>
    public class ConversionUnits
    {
        /// <summary>
        /// Enum Class For Units.
        /// </summary>
        public enum Unit
        {
            FEET,
            INCH,
            YARD,
            CENTIMETER,
            LITRE,
            GALLON,
            MILLILITRE,
            KILOGRAM,
            GRAM,
            TONNE,
            CELSIUS,
            FAHRENHEIT,
        }

        /// <summary>
        /// Method For Getting Conversion Factor.
        /// </summary>
        /// <param name="units">Enum for Units.</param>
        /// <returns>Conversion Factor.</returns>
        public static double GetConvertionFactor(Unit units)
        {
            return units switch
            {
                Unit.FEET => 1 * 12.0,
                Unit.INCH => 1.0,
                Unit.YARD => 1 * 36.0,
                Unit.CENTIMETER => 1 / 2.5,
                Unit.LITRE => 1.0,
                Unit.GALLON => 3.78,
                Unit.MILLILITRE => 1.0 / 1000,
                Unit.KILOGRAM => 1.0,
                Unit.GRAM => 1.0 / 1000,
                Unit.TONNE => 1 * 1000.0,
                Unit.CELSIUS => 1.8,
                Unit.FAHRENHEIT => 1.0,
                _ => 0.0,
            };
        }
    }
}
