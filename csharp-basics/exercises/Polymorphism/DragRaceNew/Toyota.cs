namespace DragRace
{
    public class Toyota : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 5;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "phphphph.....";
        }
    }
}
