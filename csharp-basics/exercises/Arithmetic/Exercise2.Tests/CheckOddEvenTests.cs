using System;
using Exercise_2;
using Xunit;
using Xunit.Sdk;

namespace Exercise2.Tests
{
    public class CheckOddEvenTests
    {
        [Fact]
        public void OddOrEven_4_ShouldBeEven()
        {
            //Arrange
            var number = 4;
            var expected = "Even number";

            //Act
            var actual = CheckOddEven.OddOrEven(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OddOrEven_Minus3_ShouldBeOdd()
        {
            //Arrange
            var number = -3;
            var expected = "Odd number";

            //Act
            var actual = CheckOddEven.OddOrEven(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckInput_string_ShouldThrowNotAnIntegerException()
        {
            //Arrange
            var input = "random input";

            //Act
            Action act = () => CheckOddEven.ParseInputToInteger(input);

            //Assert
            Assert.Throws<NotAnIntegerException>(act);
        }

        [Fact]
        public void CheckInput_string_ShouldReturnInteger()
        {
            //Arrange
            var expected = 52;

            //Act
            var actual = CheckOddEven.ParseInputToInteger(expected.ToString());

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
