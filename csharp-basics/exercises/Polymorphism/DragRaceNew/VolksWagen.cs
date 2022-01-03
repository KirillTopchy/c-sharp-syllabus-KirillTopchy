namespace DragRace
{
    public class VolksWagen : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 12;
        }

        public void SlowDown()
        {
            _currentSpeed -= 12;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "BRRRRR.....";
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 50;
        }
    }
}
