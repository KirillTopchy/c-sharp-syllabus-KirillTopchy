using System;
using Xunit;

namespace GravityCalculator.Tests
{
    public class FinalPositionCalculatorTests
    {
        [Fact]
        public void GetFinalPosition_minus9Point81_10_0_0_ShouldReturn490Point5()
        {
            //Arrange
            const double gravity = -9.81;
            const double fallingTime = 10;
            const double initVelocity = 0;
            const double initPosition = 0;
            var expected = -490.5;

            //Act
            var actual = FinalPositionCalculator.GetFinalPosition(gravity, fallingTime, initVelocity, initPosition);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFinalPosition_minus9Point81_10_5Point5_50Point3_ShouldReturn490Point5()
        {
            //Arrange
            const double gravity = -9.81;
            const double fallingTime = 10;
            const double initVelocity = 5.5;
            const double initPosition = 50.3;
            var expected = -434.7;

            //Act
            var actual = FinalPositionCalculator.GetFinalPosition(gravity, fallingTime, initVelocity, initPosition);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
