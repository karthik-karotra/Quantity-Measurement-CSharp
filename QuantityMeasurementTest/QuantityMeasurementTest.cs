﻿// <copyright file="QuantityMeasurementTest.cs" company="BridgeLabz Solutions">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using System;
    using NUnit.Framework;
    using QuantityMeasurementProblem;

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

        /// <summary>
        /// Test method for checking equality between 0 centimeter and 0 centimeter.
        /// </summary>
        [Test]
        public void GivenZeroCentimeterAndZeroCentimeter_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CENTIMETER);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CENTIMETER);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same centimeter values.
        /// </summary>
        [Test]
        public void GivenTwoSameCentimeterValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CENTIMETER);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CENTIMETER);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different centimeter values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentCentimeterValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CENTIMETER);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.CENTIMETER);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 inch and 0 centimeter.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroCentimeter_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CENTIMETER);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 inch and 5 centimeter.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCentimeter_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(2.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(5.0, ConversionUnits.Unit.CENTIMETER);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking addition of 2 inch and 2 inch is 4 inch.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnFourInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(2.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(2.0, ConversionUnits.Unit.INCH);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(4.0, total);
        }

        /// <summary>
        /// Test method for checking addition of 1 feet and 2 inch is 14 inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnFourteenInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double valueTwo = this.quantityMeasurement.UnitConversion(2.0, ConversionUnits.Unit.INCH);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(14.0, total);
        }

        /// <summary>
        /// Test method for checking addition of 1 feet and 1 feet is 24 inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnTwentyFourInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FEET);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(24.0, total);
        }

        /// <summary>
        /// Test method for checking addition of 2 inch and 2.5 centimeter is 3 inch.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoAndHalfCentimeter_WhenAdded_ShouldReturnThreeInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(2.0, ConversionUnits.Unit.INCH);
            double valueTwo = this.quantityMeasurement.UnitConversion(2.5, ConversionUnits.Unit.CENTIMETER);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(3.0, total);
        }

        /// <summary>
        /// Test method for checking equality between 0 litre and 0 litre.
        /// </summary>
        [Test]
        public void GivenZeroLitreAndZeroLitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same litre values.
        /// </summary>
        [Test]
        public void GivenTwoSameLitreValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different litre values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentLitreValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.LITRE);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 gallon and 0 gallon.
        /// </summary>
        [Test]
        public void GivenZeroGallonAndZeroGallon_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GALLON);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same gallon values.
        /// </summary>
        [Test]
        public void GivenTwoSameGallonValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GALLON);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different gallon values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentGallonValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.GALLON);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 millilitre and 0 millilitre.
        /// </summary>
        [Test]
        public void GivenZeroMililitreAndZeroMililitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.MILLILITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same millilitre values.
        /// </summary>
        [Test]
        public void GivenTwoSameMililitreValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.MILLILITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different millilitre values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentMililitreValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.MILLILITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 gallon and 0 litre.
        /// </summary>
        [Test]
        public void GivenZeroGallonAndZeroLitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 gallon and 0 millilitre.
        /// </summary>
        [Test]
        public void GivenZeroGallonAndZeroMililitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 litre and 0 millilitre.
        /// </summary>
        [Test]
        public void GivenZeroLitreAndZeroMililitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 gallon and 3.78 litre.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreePointSevenEightLitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(3.78, ConversionUnits.Unit.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 litre and 1000 millilitre.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneThousandMillilitre_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1000.0, ConversionUnits.Unit.MILLILITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking addition of 1 gallon and 3.78 litre is 7.56 litre.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreePointSevenEightLitre_WhenAdded_ShouldReturnSevenPointFiveSixLitre()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GALLON);
            double valueTwo = this.quantityMeasurement.UnitConversion(3.78, ConversionUnits.Unit.LITRE);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(7.56, Math.Ceiling(total * 100) / 100);
        }

        /// <summary>
        /// Test method for checking addition of 1 litre and 1000 millilitre is 2 litre.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneThousandMillilitre_WhenAdded_ShouldReturnTwoLitre()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.LITRE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1000.0, ConversionUnits.Unit.MILLILITRE);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(2.0, total);
        }

        /// <summary>
        /// Test method for checking equality between 0 kilogram and 0 kilogram.
        /// </summary>
        [Test]
        public void GivenZeroKilogramAndZeroKilogram_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.KILOGRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same kilogram values.
        /// </summary>
        [Test]
        public void GivenTwoSameKilogramValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.KILOGRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different kilogram values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentKilogramValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.KILOGRAM);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 gram and 0 gram.
        /// </summary>
        [Test]
        public void GivenZeroGramAndZeroGram_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same gram values.
        /// </summary>
        [Test]
        public void GivenTwoSameGramValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different gram values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentGramValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.GRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.GRAM);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 tonne and 0 tonne.
        /// </summary>
        [Test]
        public void GivenZeroTonneAndZeroTonne_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.TONNE);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.TONNE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same tonne values.
        /// </summary>
        [Test]
        public void GivenTwoSameTonneValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.TONNE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.TONNE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different tonne values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentTonneValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.TONNE);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.TONNE);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 kilogram and 0 gram.
        /// </summary>
        [Test]
        public void GivenZeroKilogramAndZeroGram_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 kilogram and 0 tonne.
        /// </summary>
        [Test]
        public void GivenZeroKilogramAndZeroTonne_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.TONNE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 gram and 0 tonne.
        /// </summary>
        [Test]
        public void GivenZeroGramAndZeroTonne_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.GRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.TONNE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 kilogram and 1000 gram.
        /// </summary>
        [Test]
        public void GivenOneKilogramAndOneThousandGram_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.KILOGRAM);
            double valueTwo = this.quantityMeasurement.UnitConversion(1000.0, ConversionUnits.Unit.GRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 1 tonne and 1000 kilogram.
        /// </summary>
        [Test]
        public void GivenOneTonneAndOneThousandKilogram_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.TONNE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1000.0, ConversionUnits.Unit.KILOGRAM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking addition of 1 tonne and 1000 gram is 1001 kilogram.
        /// </summary>
        [Test]
        public void GivenOneTonneAndOneThousandGram_WhenAdded_ShouldReturnOneThousandAndOneKilogram()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.TONNE);
            double valueTwo = this.quantityMeasurement.UnitConversion(1000.0, ConversionUnits.Unit.GRAM);
            double total = this.quantityMeasurement.AddUnits(valueOne, valueTwo);
            Assert.AreEqual(1001.0, total);
        }

        /// <summary>
        /// Test method for checking equality between 0 celsius and 0 celsius.
        /// </summary>
        [Test]
        public void GivenZeroCelsiusAndZeroCelsius_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CELSIUS);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CELSIUS);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same celsius values.
        /// </summary>
        [Test]
        public void GivenTwoSameCelsiusValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CELSIUS);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CELSIUS);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different celsius values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentCelsiusValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.CELSIUS);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.CELSIUS);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 fahrenheit and 0 fahrenheit.
        /// </summary>
        [Test]
        public void GivenZeroFahrenheitAndZeroFahrenheit_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FAHRENHEIT);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FAHRENHEIT);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 same fahrenheit values.
        /// </summary>
        [Test]
        public void GivenTwoSameFahrenheitValues_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FAHRENHEIT);
            double valueTwo = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FAHRENHEIT);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 2 different fahrenheit values.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFahrenheitValues_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(1.0, ConversionUnits.Unit.FAHRENHEIT);
            double valueTwo = this.quantityMeasurement.UnitConversion(10.0, ConversionUnits.Unit.FAHRENHEIT);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 0 degree and 0 fahrenheit.
        /// </summary>
        [Test]
        public void GivenZeroFahrenheitAndZeroCelsius_WhenCompared_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.FAHRENHEIT);
            double valueTwo = this.quantityMeasurement.UnitConversion(0.0, ConversionUnits.Unit.CELSIUS);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test method for checking equality between 212 fahrenheit and 100 celsius.
        /// </summary>
        [Test]
        public void GivenTwoHundredAndTwelveFahrenheitAndOneHundredCelsius_WhenCompared_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(212.0, ConversionUnits.Unit.FAHRENHEIT);
            double valueTwo = this.quantityMeasurement.UnitConversion(100.0, ConversionUnits.Unit.CELSIUS);
            Assert.AreEqual(valueOne, valueTwo);
        }
    }
}