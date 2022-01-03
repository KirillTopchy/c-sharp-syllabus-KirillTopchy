using Exercise_1;
using Xunit;

namespace Exercise1.Tests
{
    public class IntegerAnalyzerTests
    {
        [Fact]
        public void CompareIntegers_15_55_ShouldReturnTrueWithFirstIntegerIsEquals15()
        {
            //Arrange
            var firstInteger = 15;
            var secondInteger = 55;

            //Act
            var result = IntegerAnalyzer.CompareIntegers(firstInteger, secondInteger);
            
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareIntegers_60_15_ShouldReturnTrueWithSecondIntegerIsEquals15()
        {
            //Arrange
            var firstInteger = 60;
            var secondInteger = 15;

            //Act
            var result = IntegerAnalyzer.CompareIntegers(firstInteger, secondInteger);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareIntegers_10_5_ShouldReturnTrueIfSumOfTwoIntegersIs15()
        {
            //Arrange
            var firstInteger = 10;
            var secondInteger = 5;

            //Act
            var result = IntegerAnalyzer.CompareIntegers(firstInteger, secondInteger);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareIntegers_20_5_ShouldReturnTrueIfFirstIntegerSubtractSecondIntegerIs15()
        {
            //Arrange
            var firstInteger = 20;
            var secondInteger = 5;

            //Act
            var result = IntegerAnalyzer.CompareIntegers(firstInteger, secondInteger);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareIntegers_20_35_ShouldReturnTrueIfSecondIntegerSubtractFirstIntegerIs15()
        {
            //Arrange
            var firstInteger = 20;
            var secondInteger = 35;

            //Act
            var result = IntegerAnalyzer.CompareIntegers(firstInteger, secondInteger);

            //Assert
            Assert.True(result);
        }
    }
}
