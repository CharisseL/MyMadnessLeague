using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMadnessLeague.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MyMadnessLeague
{
    public class ScoreContext : DbContext
    {
            public DbSet<Score> Scores { get; set; }
    }
}
