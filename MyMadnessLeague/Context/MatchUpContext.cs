using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyMadnessLeague.Models; 

namespace MyMadnessLeague
{
    public class MatchUpContext: DbContext
    {
       
        public DbSet<MatchUp> Matchups { get; set; }
        

    }
}
