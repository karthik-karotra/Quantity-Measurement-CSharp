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
        /// <summary>
        /// SetUp Method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Method.
        /// </summary>
        [Test]
        public void Test1()
        {
            double feet1 = QuantityMeasurementMain.GetFeet(0.0);
            double feet2 = QuantityMeasurementMain.GetFeet(0.0);
            Assert.AreEqual(feet1, feet2);
        }
    }
}