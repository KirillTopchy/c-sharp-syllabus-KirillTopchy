using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void StartEngine()
        {
            Console.WriteLine("BRRRRR.....");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 50;
        }
    }
}
