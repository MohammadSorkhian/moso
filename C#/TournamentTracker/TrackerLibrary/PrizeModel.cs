using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }
        public string placeName { get; set; }
        public decimal prizeAmount { get; set; }
        public double prizePercentage { get; set; }
    }
}
