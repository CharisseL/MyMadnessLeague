using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMadnessLeague.Models
{
    public class Scoreboard
    {
        public int ScoreboardID { get; set; }
        public string Player { get; set; }
        public int  Player_Score { get; set; }

    }
    public class ScoreDBContext : DbContext
    {
        public DbSet<Scoreboard> Scoreboards { get; set; }
    }
}