// <copyright file="QuantityMeasurement.cs" company="BridgeLabz Solutions">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    /// <summary>
    /// Quantity Measurement Class.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// method to get feet.
        /// </summary>
        /// <param name="value">value to get converted.</param>
        /// <param name="unit">unit of value to get converted.</param>
        /// <returns>converted value.</returns>
        public double UnitConversion(double value, ConversionUnits.Unit unit)
        {
            double conversionFactor = ConversionUnits.GetConvertionFactor(unit);
            return conversionFactor * value;
        }

        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object Of Quantity Measurement Main Class.</param>
        /// <returns>Boolean Value According To Object.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj is QuantityMeasurement)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// HashCode Of Object.
        /// </summary>
        /// <returns>Returns HashCode.</returns>
        public override int GetHashCode() => base.GetHashCode();
    }
}