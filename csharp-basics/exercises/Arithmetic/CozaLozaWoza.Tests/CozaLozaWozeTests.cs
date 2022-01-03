using System;
using Xunit;

namespace CozaLozaWoza.Tests
{
    public class CozaLozaWozeTests
    {
        [Fact]
        public void PlayCozaLozaWoza_1_1_ShouldReturnString1()
        {
            //Arrange
            const int min = 1, max = 1;
            var expected = "1 ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_3_3_ShouldReturnString12Coza()
        {
            //Arrange
            const int min = 3, max =3;
            var expected = "Coza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_5_5_ShouldReturnStringLoza()
        {
            //Arrange
            const int min = 5, max = 5;
            var expected = "Loza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_7_7_ShouldReturnStringWoza()
        {
            //Arrange
            const int min = 7, max = 7;
            var expected = "Woza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_15_15_ShouldReturnStringCozaLoza()
        {
            //Arrange
            const int min = 15, max = 15;
            var expected = "CozaLoza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_15_15_ShouldReturnStringLozaWoza()
        {
            //Arrange
            const int min = 70, max = 70;
            var expected = "LozaWoza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_21_21_ShouldReturnStringCozaWoza()
        {
            //Arrange
            const int min = 21, max = 21;
            var expected = "CozaWoza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlayCozaLozaWoza_105_105_ShouldReturnStringCozaWoza()
        {
            //Arrange
            const int min = 105, max = 105;
            var expected = "CozaLozaWoza ";

            //Act
            var actual = CozaLozaWoza.PlayCozaLozaWoza(min, max);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
