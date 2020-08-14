// <copyright file="QuantityMeasurementMain.cs" company="BridgeLabz Solutions">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    /// <summary>
    /// Quantity Measurement Class.
    /// </summary>
    public class QuantityMeasurementMain
    {
        /// <summary>
        /// method to get feet.
        /// </summary>
        /// <param name="feet">feet value to get converted.</param>
        /// <returns>feet.</returns>
        public double GetFeet(double feet)
        {
            return feet;
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

            if (obj is QuantityMeasurementMain)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// HashCode Of Object.
        /// </summary>
        /// <returns>Returns HashCode.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}