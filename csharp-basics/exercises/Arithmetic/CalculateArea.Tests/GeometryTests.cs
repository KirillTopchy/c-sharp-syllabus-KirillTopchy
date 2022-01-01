using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_5_ShouldReturn78Point54()
        {
            //Arrange
            var radius = 5;
            var expected = 78.54;

            //Act
            var result = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaOfRectangle_5_5_ShouldReturn25Point00()
        {
            //Arrange
            var length = 5;
            var width = 5;
            var expected = 25.00;

            //Act
            var result = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaOfTriangle_10_6_ShouldReturn30Point00()
        {
            //Arrange
            var ground = 10;
            var height = 6;
            var expected = 30.00;

            //Act
            var result = Geometry.AreaOfTriangle(ground, height);

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
