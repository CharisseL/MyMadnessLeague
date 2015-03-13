using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMadnessLeague.Models
{
    public class MatchUp
    {
        public int MatchUpId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string MatchWinner { get; set; }

        public MatchUp()
        {

        }

    }
}