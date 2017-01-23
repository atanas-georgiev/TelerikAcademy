namespace NightlifeEntertainment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SportsHall : Venue
    {
        public SportsHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Sport, PerformanceType.Concert })
        {
        }
    }
}
