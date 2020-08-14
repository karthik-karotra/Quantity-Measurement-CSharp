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
        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// SetUp Method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// Test method for checking equality between 0 feet and 0 feet.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenEqual_ShouldReturnTrue()
        {
            double feetOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            double feetTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(feetOne, feetTwo);
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
            QuantityMeasurement quantityMeasurementOne = new QuantityMeasurement();
            QuantityMeasurement quantityMeasurementTwo = new QuantityMeasurement();
            Assert.AreEqual(quantityMeasurementOne, quantityMeasurementTwo);
        }

        /// <summary>
        /// Test method for equality check of 2 same feet values.
        /// </summary>
        [Test]
        public void GivenTwoSameFeetValues_WhenEqual_ShouldReturnTrue()
        {
            double feetOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double feetTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Test method for equality check of 2 different feet values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenEqual_ShouldReturnFalse()
        {
            double feetOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double feetTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.FEET);
            Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 inch and 0 inch.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_WhenEqual_ShouldReturnTrue()
        {
            double inchOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            double inchTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test method for equality check of 2 same inch values.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenEqual_ShouldReturnTrue()
        {
            double inchOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double inchTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test method for equality check of 2 different inch values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenEqual_ShouldReturnFalse()
        {
            double inchOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double inchTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.INCH);
            Assert.AreNotEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 feet and 0 inch.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroInch_ShouldReturnTrue()
        {
            double feet = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            double inch = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Test method for checking equality between 1 feet and 1 inch.
        /// </summary>
        [Test]
        public void GivenOneFeet_WhenComparedWithOneInch_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreNotEqual(1.0, valueOne);
        }

        /// <summary>
        /// Test method for checking equality between 1 inch and 1 feet.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneFeet_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 feet and 12 inch.
        /// </summary>
        [Test]
        public void GivenOneFeet_WhenComparedWithTwelveInch_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(12.0, valueOne);
        }

        /// <summary>
        /// Test method for checking equality between 12 inch and 1 feet.
        /// </summary>
        [Test]
        public void GivenTwelveInchAndOneFeet_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(12.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 yard and 0 yard.
        /// </summary>
        [Test]
        public void GivenZeroYardAndZeroYard_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.YARD);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same yard values.
        /// </summary>
        [Test]
        public void GivenTwoSameYardValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different yard values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentYardValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.YARD);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 feet and 0 yard.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroYard_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FEET);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 inch and 0 yard.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroYard_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 3 feet and 1 yard.
        /// </summary>
        [Test]
        public void GivenThreeFeetAndOneYard_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(3.0, ConversionUnits.Unit.FEET);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 feet and 1 yard.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneYard_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 inch and 1 yard.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneYard_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 yard and 36 inch.
        /// </summary>
        [Test]
        public void GivenOneYardAndThirtySixInch_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            double valueTwo = this.quantityMeasurement.UnitConversion(36.0, ConversionUnits.Unit.INCH);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 36 inch and 1 yard.
        /// </summary>
        [Test]
        public void GivenThirtySixInchAndOneYard_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(36.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 yard and 3 feet.
        /// </summary>
        [Test]
        public void GivenOneYardAndThreeFeet_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.YARD);
            double valueTwo = this.quantityMeasurement.UnitConversion(3.0, ConversionUnits.Unit.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

    }
}