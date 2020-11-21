using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TournamentModel
    {
        public string Tournament { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> enteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupMoleds>> Rounds { get; set; } = new List<List<MatchupMoleds>>();

    }
}
