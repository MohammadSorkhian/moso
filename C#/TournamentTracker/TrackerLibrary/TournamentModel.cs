using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string tournamnetName { get; set; }
        public decimal entryFee { get; set; }
        public List<TeamModel> entryTeams { get; set; }
        public List<PrizeModel> prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
