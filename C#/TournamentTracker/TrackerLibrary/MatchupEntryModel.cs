using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel teamCompeting { get; set; }
        public double score { get; set; }
        public MatchupModel parentMatchup { get; set; }
    }
}
