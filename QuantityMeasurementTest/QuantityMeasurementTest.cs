// <copyright file="QuantityMeasurementTest.cs" company="BridgeLabz Solutions">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// Quantity Measurement Class.
    /// </summary>
    public class QuantityMeasurementTest
    {
        private QuantityMeasurementMain quantityMeasurement;

        /// <summary>
        /// SetUp Method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurementMain();
        }

        /// <summary>
        /// Test method for checking equality between o feet and o feet.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.GetFeet(0.0);
            double feet2 = this.quantityMeasurement.GetFeet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test method for checking equality between o feet and o feet.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method for checking class reference.
        /// </summary>
        [Test]
        public void GivenClassReference_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test method for checking type.
        /// </summary>
        [Test]
        public void GivenClassReference_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurementMain quantityMeasurement1 = new QuantityMeasurementMain();
            QuantityMeasurementMain quantityMeasurement2 = new QuantityMeasurementMain();
            Assert.AreEqual(quantityMeasurement1, quantityMeasurement2);
        }

        /// <summary>
        /// Test method for equality check of 2 same feet values.
        /// </summary>
        [Test]
        public void GivenTwoSameFeetValues_WhenEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.GetFeet(1.0);
            double feet2 = this.quantityMeasurement.GetFeet(1.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test method for equality check of 2 different feet values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenEqual_ShouldReturnFalse()
        {
            double feet1 = this.quantityMeasurement.GetFeet(1.0);
            double feet2 = this.quantityMeasurement.GetFeet(10.0);
            Assert.AreNotEqual(feet1, feet2);
        }
    }
}