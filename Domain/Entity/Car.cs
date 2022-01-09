using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int Speed { get; set; }
        public double MulfuctionChance { get; set; }
        public int MulfuctionOccured { get; set; }
        public int DistanceCoveredInMiles { get; set; }
        public int FinishRace { get; set; }
        public int RacedForHour { get; set; }

    }
}
