using Exercise_6;
using Xunit;

namespace Exercise6.Tests
{
    public class TigerTest
    {
        private Tiger _target;

        public TigerTest()
        {
            _target = new Tiger("Bobby", "tiger", 750, 2, "Africa");
        }

        [Fact]
        public void MakeSound_Roar_ShouldReturnRoar()
        {
            //Arrange
            var expected = "ROAR";

            //Act
            var actual = _target.MakeSound();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_Vegetable_ShouldBeFalse()
        {
            //Arrange
            Food vegetable = new Vegetable(1);

            //Assert
            Assert.False(_target.Eat(vegetable));
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