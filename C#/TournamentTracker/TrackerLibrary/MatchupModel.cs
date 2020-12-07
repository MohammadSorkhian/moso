using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> entries { get; set; }
        public TeamModel winner { get; set; }
        public int matchupRound { get; set; }
    }
}
