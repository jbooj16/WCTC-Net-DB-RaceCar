using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class NissanSkyline : RaceCar
    {
        public NissanSkyline()
        {
            Name = "Nissan Skyline";
            TopSpeed = 200;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} turns on and is spitting flames from the exhaust!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}