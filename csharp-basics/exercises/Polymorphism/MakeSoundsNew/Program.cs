using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundsList = new List<ISound>
            {
                new Firework(),
                new Parrot(),
                new Radio(),
                new Parrot(),
                new Parrot(),
                new Radio(),
                new Firework()
            };

            soundsList.ForEach(sound => sound.PlaySound());
        }
    }
}
