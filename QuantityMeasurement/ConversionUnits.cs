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
                _ => 0.0,
            };
        }
    }
}
