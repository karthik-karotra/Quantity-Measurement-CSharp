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
        /// Test method for checking equality between 0 feet and 0 feet.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            double feet2 = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test method for checking null reference for feet.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method for checking class reference for feet.
        /// </summary>
        [Test]
        public void GivenClassReferenceForFeet_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test method for checking type for feet.
        /// </summary>
        [Test]
        public void GivenClassReferenceForFeet_WhenTypeChecked_ShouldReturnTrue()
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
            double feet1 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double feet2 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test method for equality check of 2 different feet values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenEqual_ShouldReturnFalse()
        {
            double feet1 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double feet2 = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.FEET);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test method for checking equality between 0 inch and 0 inch.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_WhenEqual_ShouldReturnTrue()
        {
            double inch1 = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            double inch2 = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test method for checking null reference for inch.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test method for checking class reference for inch.
        /// </summary>
        [Test]
        public void GivenClassReferenceForInch_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test method for checking type.
        /// </summary>
        [Test]
        public void GivenClassReferenceForInch_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurementMain quantityMeasurement1 = new QuantityMeasurementMain();
            QuantityMeasurementMain quantityMeasurement2 = new QuantityMeasurementMain();
            Assert.AreEqual(quantityMeasurement1, quantityMeasurement2);
        }

        /// <summary>
        /// Test method for equality check of 2 same inch values.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenEqual_ShouldReturnTrue()
        {
            double inch1 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double inch2 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test method for equality check of 2 different inch values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenEqual_ShouldReturnFalse()
        {
            double inch1 = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double inch2 = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.INCH);
            Assert.AreNotEqual(inch1, inch2);
        }
    }
}