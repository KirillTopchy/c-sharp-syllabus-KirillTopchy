using Xunit;

namespace DragRace.Tests
{
    public class ToyotaTests
    {
        private Toyota _target;

        public ToyotaTests()
        {
            _target = new Toyota();
        }

        [Fact]
        public void SpeedUp_target_ShouldIncreaseSpeedBy10()
        {
            //Arrange
            var expected = "5";

            //Act
            _target.SpeedUp();
            var actual = _target.ShowCurrentSpeed();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_target_SpeedShouldDecreaseBy10()
        {
            //Arrange
            _target.SpeedUp();
            _target.SpeedUp();
            _target.SpeedUp();
            var expected = "10";

            //Act
            _target.SlowDown();
            var actual = _target.ShowCurrentSpeed();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_target_SpeedShouldDecreaseBy10()
        {
            //Arrange
            var expected = "phphphph.....";

            //Act
            _target.SlowDown();
            var actual = _target.StartEngine();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}