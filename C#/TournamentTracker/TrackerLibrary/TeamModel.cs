using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{

    public class TeamModel
    {
        public List<PersonModel> teamMembers { get; set; } = new List<PersonModel>();
        public string teamName { get; set; }


    }
}
