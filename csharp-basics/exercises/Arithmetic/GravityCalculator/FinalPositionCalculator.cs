using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class FinalPositionCalculator
    {
        public static double GetFinalPosition(double gravity, double fallingTime, double initialVelocity, double initialPosition)
        {
            return Math.Round((gravity * fallingTime * fallingTime) / 2 + initialVelocity + initialPosition, 1);
        }
    }
}
