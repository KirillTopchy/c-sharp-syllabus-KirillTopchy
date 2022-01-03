using Xunit;

namespace DragRace.Tests
{
    public class VolksWagenTests
    {
        private VolksWagen _target;

        public VolksWagenTests()
        {
            _target = new VolksWagen();
        }

        [Fact]
        public void SpeedUp_target_ShouldIncreaseSpeedBy10()
        {
            //Arrange
            var expected = "12";

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
            var expected = "24";

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
            var expected = "BRRRRR.....";

            //Act
            _target.SlowDown();
            var actual = _target.StartEngine();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseNitrousOxideEngine_target_SpeedShouldIncreaseBy40()
        {
            //Arrange
            var expected = "50";

            //Act
            _target.UseNitrousOxideEngine();

            //Assert
            Assert.Equal(expected, _target.ShowCurrentSpeed());
        }
    }
}