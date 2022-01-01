using Exercise_6;
using Xunit;

namespace Exercise6.Tests
{
    public class CreateArrayTests
    {
        [Fact]
        public void CreateRandomNumberArray_10_ShouldCreateArrayWithLength10()
        {
            //Arrange
            var length = 10;

            //Act
            var array =CreateArray.CreateRandomNumberArray(length);

            //Assert
            Assert.Equal(length,array.Length);
        }

        [Fact]
        public void CopyArray_intArray_CopiedArrayShouldBeTheSameAsPassedArray()
        {
            //Arrange
            var length = 10;
            var passedArray = CreateArray.CreateRandomNumberArray(length);

            //Act
            var copiedArray = CreateArray.CopyArray(passedArray);

            //Assert
            for (int i = 0; i < copiedArray.Length; i++)
            {
                Assert.Equal(passedArray[i], copiedArray[i]);
            }
        }

        [Fact]
        public void ReplaceLastElementOfArrayWith7_intArray_ShouldChangePassedArrayLastElementValueToMinus7()
        {
            //Arrange
            var lastElement = -7;
            var length = 10;
            var randomNumbersArray = CreateArray.CreateRandomNumberArray(length);

            //Act
            CreateArray.ReplaceLastElementOfArrayWith7(randomNumbersArray);

            //Assert
            Assert.Equal(lastElement, randomNumbersArray[^1]);
        }
    }
}
