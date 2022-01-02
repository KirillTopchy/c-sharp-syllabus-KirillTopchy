namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 10;
        }

        public void SlowDown()
        {
            _currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed+=40;
        }

        public string StartEngine()
        {
            return "Bruuummmm.....";
        }
    }
}