namespace NightlifeEntertainment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConcertHall : Venue
    {
        public ConcertHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Opera, PerformanceType.Concert, PerformanceType.Theatre })
        {
        }
    }
}
