using Exercise_6;
using Xunit;

namespace Exercise6.Tests
{
    public class CatTests
    {
        private Cat _target;

        public CatTests()
        {
            _target = new Cat("Borja", "cat", 3.5, 3, "Apartments", "Persian");
        }

        [Fact]
        public void MakeSound_MurMurMur_ShouldReturnMurMurMur()
        {
            //Arrange
            var expected = "MurMurMur";

            //Act
            var actual = _target.MakeSound();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_Vegetable_ShouldBeTrue()
        {
            //Arrange
            Food vegetable = new Vegetable(1);

            //Assert
            Assert.True(_target.Eat(vegetable));
        }

        [Fact]
        public void Eat_Meat_ShouldBeTrue()
        {
            //Arrange
            Food meat = new Meat(1);

            //Assert
            Assert.True(_target.Eat(meat));
        }
    }
}