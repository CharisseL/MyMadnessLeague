using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMadnessLeague;
using System.Data.Entity;
using System.Web;
using MyMadnessLeague.Models;

namespace MyMadnessLeague.Repository
{
    public class MatchUpRepository : IMatchUpRepository
    {
        private MatchUpContext _dbContext;

        public MatchUpRepository()
        {
            _dbContext = new MatchUpContext();
            _dbContext.Matchups.Load();
        }  

        public MatchUpContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.MatchUp> GetDbSet()
        {
            return _dbContext.Matchups;
        }

        public void Add(Models.MatchUp Game)
        {
            _dbContext.Matchups.Add(Game);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.MatchUp> All()
        {
            var qu = from MatchUp in _dbContext.Matchups
                     select MatchUp;
            return qu.ToList<Models.MatchUp>();

        }

    }
}
