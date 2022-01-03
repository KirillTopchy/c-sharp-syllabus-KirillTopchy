using Exercise_6;
using Xunit;

namespace Exercise6.Tests
{
    public class ZebraTests
    {
        private Zebra _target;

        public ZebraTests()
        {
            _target = new Zebra("Marti", "Zebra", 400, 2, "Africa");
        }

        [Fact]
        public void MakeSound_Igogo_ShouldReturnIgogo()
        {
            //Arrange
            var expected = "Igogo";

            //Act
            var actual = _target.MakeSound();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_Vegetable_ShouldBeTrue()
        {
            //Arrange
            var vegetable = new Vegetable(3);

            //Assert
            Assert.True(_target.Eat(vegetable));
        }

        [Fact]
        public void Eat_Meat_ShouldBeFalse()
        {
            //Arrange
            var meat = new Meat(3);

            //Assert
            Assert.False(_target.Eat(meat));
        }

    }
}
