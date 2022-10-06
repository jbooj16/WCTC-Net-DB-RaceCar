using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BrianOconnor : Driver
    {
        public BrianOconnor(RaceCar car) : base(car)
        {
            Name = "Brian O'Connor";
            SkillLevel = 10;
        }
        
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}