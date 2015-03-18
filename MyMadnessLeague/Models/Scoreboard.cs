using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMadnessLeague.Models
{
    public class Scoreboard
    {
        public int ScoreboardId { get; set; }
        public string Player { get; set; }
        public int  Score { get; set; }

    }
    public class ScoreDBContext : DbContext
    {
        public DbSet<Score> Scores { get; set; }
    }
}