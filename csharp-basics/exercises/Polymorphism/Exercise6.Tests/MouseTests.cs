using Exercise_6;
using Xunit;

namespace Exercise6.Tests
{
    public class MouseTests
    {
        private Mouse _target;

        public MouseTests()
        {
            _target = new Mouse("Stuart", "mouse", 0.2, 0, "Holes in the walls");
        }

        [Fact]
        public void MakeSound_MiMiMi_ShouldReturnMiMiMi()
        {
            //Arrange
            var expected = "MiMiMi";

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
        public void Eat_Meat_ShouldBeFalse()
        {
            //Arrange
            Food meat = new Meat(1);

            //Assert
            Assert.False(_target.Eat(meat));
        }
    }
}
